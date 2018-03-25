using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreePostorderTraversal
    {
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            PostorderTraversal(root, values);

            return values;
        }

        public static void PostorderTraversal(TreeNode root, IList<int> values)
        {
            if (root == null)
                return;

            PostorderTraversal(root.left, values);
            PostorderTraversal(root.right, values);
            values.Add(root.val);
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
