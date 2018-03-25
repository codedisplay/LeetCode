using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreePreorderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            PreorderTraversal(root, values);

            return values;
        }

        public static void PreorderTraversal(TreeNode root, IList<int> values)
        {
            if (root == null)
                return;

            values.Add(root.val);
            PreorderTraversal(root.left, values);
            PreorderTraversal(root.right, values);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }
}
