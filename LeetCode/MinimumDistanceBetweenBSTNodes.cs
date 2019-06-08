using LeetCode.Model;
using System;

namespace LeetCode
{
    public class MinimumDistanceBetweenBSTNodes
    {
        public int lastValue = 0;

        public int MinDiffInBST(TreeNode root)
        {
            lastValue = root.val > 0 ? int.MaxValue : -int.MaxValue;
            int minDiff = int.MaxValue;
            GetMinimumDifference(root, ref minDiff);
            return minDiff;
        }

        public void GetMinimumDifference(TreeNode root, ref int minDiff)
        {
            if (root == null)
                return;

            GetMinimumDifference(root.left, ref minDiff);

            minDiff = Math.Min(Math.Abs(lastValue - root.val), minDiff);
            lastValue = root.val;

            GetMinimumDifference(root.right, ref minDiff);
        }
    }
}
