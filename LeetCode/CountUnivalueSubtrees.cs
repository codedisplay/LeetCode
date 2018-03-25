namespace LeetCode
{
    public class CountUnivalueSubtrees
    {
        public static int CountUnivalSubtrees(TreeNode root)
        {
            //if (root == null)
            //    return 0;

            int count = GetUnivalSubtrees(root, 0, root.val);

            return count;
        }

        private static int GetUnivalSubtrees(TreeNode node, int currentCount, int comparisionValue)
        {
            if (node == null)
                return currentCount;

            if (node.left == null && node.right == null)
                currentCount++;

            GetUnivalSubtrees(node.left, currentCount, node.val);

            //if (node.val == comparisionValue)
            //{

            //}

            return currentCount;
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
