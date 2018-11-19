using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode
{
    public class Leaf_SimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> values = new List<int>();

            if (root1 != null)
                GetLeafs(root1, ref values);

            int index = 0;

            if (root2 != null)
                return VerifyLeafs(root2, values, ref index);

            return values.Count == index;
        }

        private void GetLeafs(TreeNode root, ref List<int> values)
        {
            if (root.left == null && root.right == null)
                values.Add(root.val);
            else
            {
                if (root.left != null)
                    GetLeafs(root.left, ref values);
                if (root.right != null)
                    GetLeafs(root.right, ref values);
            }
        }

        private bool VerifyLeafs(TreeNode root, List<int> values, ref int currentIndex)
        {
            if (root.left == null && root.right == null)
            {
                if (values[currentIndex] != root.val || currentIndex == values.Count) return false;
                currentIndex++;
            }
            else
                return ((root.left == null || VerifyLeafs(root.left, values, ref currentIndex)) &&
                 (root.right == null || VerifyLeafs(root.right, values, ref currentIndex)));

            return true;
        }
    }
}
