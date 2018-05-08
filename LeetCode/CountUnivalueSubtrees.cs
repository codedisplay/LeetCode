namespace LeetCode
{
    public class CountUnivalueSubtrees
    {
        public int CountUnivalSubtrees(TreeNode root)
        {
            int count = 0;

            GetUnivalSubtrees(root, ref count);

            return count;
        }

        private bool GetUnivalSubtrees(TreeNode node, ref int currentCount)
        {
            if (node == null)
                return true;

            bool isLeftValid = GetUnivalSubtrees(node.left, ref currentCount);
            bool isRightValid = GetUnivalSubtrees(node.right, ref currentCount);

            if ((isLeftValid && isRightValid) &&
                ((node.left == null || node.left.val == node.val) &&
                (node.right == null || node.right.val == node.val)))
            {
                currentCount++;
                return true;
            }

            return false;
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
