using LeetCode.Model;
using System;

namespace LeetCode
{
    public class DiameterofBinaryTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int max = 0;
            DiameterOfBinaryTree(root, ref max);
            return max;
        }

        public int DiameterOfBinaryTree(TreeNode root, ref int max)
        {
            if (root == null)
                return 0;

            int left = DiameterOfBinaryTree(root.left, ref max);
            int right = DiameterOfBinaryTree(root.right, ref max);

            max = Math.Max(max, left + right);
            int current = Math.Max(left, right) + 1;

            return current;
        }
    }
}
