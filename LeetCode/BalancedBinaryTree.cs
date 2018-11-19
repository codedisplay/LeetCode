using LeetCode.Model;
using System;

namespace LeetCode
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return IsBalancedHelper(root) != -1;
        }

        public int IsBalancedHelper(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = IsBalancedHelper(root.left);
            var right = IsBalancedHelper(root.right);

            return left == -1 || right == -1 || Math.Abs(left - right) > 1 ? -1 : Math.Max(left, right) + 1;
        }
    }
}
