using LeetCode.Model;

namespace LeetCode
{
    public class PathSum
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            bool hasPathSum = false;

            hasPathSum = IsPathSumExists(root, 0, sum);

            return hasPathSum;
        }

        //public static int VerifyPathSum(TreeNode root, int currentSum, int sum)
        //{
        //    if (root == null)
        //        return 0;

        //    currentSum += root.val;
        //    currentSum += VerifyPathSum(root.left, currentSum, sum);

        //    return currentSum;
        //}

        private static bool IsPathSumExists(TreeNode node, int currentSum, int sum)
        {
            if (node == null)
                return false;

            currentSum += node.val;

            if (node.left == null && node.right == null)
                if (currentSum == sum)
                    return true;

            if (IsPathSumExists(node.left, currentSum, sum))
                return true;

            if (IsPathSumExists(node.right, currentSum, sum))
                return true;

            return false;
        }
    }
}
