using LeetCode.Model;
using System;

namespace LeetCode
{
    public class BinaryTreeTilt
    {

        public int FindTilt(TreeNode root)
        {
            int max = 0;
            FindTilt(root, ref max);
            return max;
        }

        public int FindTilt(TreeNode root, ref int sum)
        {
            if (root == null)
                return 0;

            int leftSum = FindTilt(root.left, ref sum);
            int rightSum = FindTilt(root.right, ref sum);

            sum += Math.Abs(leftSum - rightSum);

            int currentSum = root.val + leftSum + rightSum;

            return currentSum;
        }


    }
}
