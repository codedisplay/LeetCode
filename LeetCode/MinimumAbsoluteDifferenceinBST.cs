using LeetCode.Model;
using System;

namespace LeetCode
{
    public class MinimumAbsoluteDifferenceinBST
    {
        public int lastValue = 0;

        public int GetMinimumDifference(TreeNode root)
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

        //public int GetMinimumDifference(TreeNode root)
        //{
        //    int minDiff = int.MaxValue;
        //    GetMinimumDifference(root, Math.Abs(int.MaxValue- root.val), ref minDiff);
        //    return minDiff;
        //}

        //public void GetMinimumDifference(TreeNode root, int previousVal, ref int minDiff)
        //{
        //    if (root == null)
        //        return;

        //    GetMinimumDifference(root.left, root.val, ref minDiff);

        //    minDiff = Math.Min(Math.Abs(previousVal - root.val), minDiff);

        //    GetMinimumDifference(root.right, root.val, ref minDiff);
        //}
    }
}
