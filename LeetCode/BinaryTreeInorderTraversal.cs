using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            InorderTraversal(root, values);

            return values;
        }

        public static void InorderTraversal(TreeNode root, IList<int> values)
        {
            if (root == null)
                return;

            InorderTraversal(root.left, values);
            values.Add(root.val);
            InorderTraversal(root.right, values);
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
