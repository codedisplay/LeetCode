using LeetCode.Model;

namespace LeetCode
{
    public class MaximumDepthofBinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            int maxDepth = -1;

            maxDepth = MaxDepth(root, maxDepth);

            return maxDepth;
        }

        public static int MaxDepth(TreeNode root, int currentDepth)
        {
            if (root == null)
                return currentDepth;

            currentDepth++;

            int leftMaxDepth = MaxDepth(root.left, currentDepth);
            int rightMaxDepth = MaxDepth(root.right, currentDepth);

            return leftMaxDepth > rightMaxDepth ? leftMaxDepth : rightMaxDepth;
        }
    }
}
