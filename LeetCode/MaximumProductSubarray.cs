using System;

namespace LeetCode
{
    public class MaximumProductSubarray
    {
        // TODO
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int max = nums[0], iMax = nums[0], iMin = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {

            }

            return max;
        }

        //// 184 / 184 test cases passed : TLE
        //public int MaxProduct(int[] nums)
        //{
        //    if (nums.Length == 1)
        //        return nums[0];

        //    int maxProd = int.MinValue;
        //    int[] dp = new int[nums.Length + 1];
        //    dp[0] = 1;

        //    for (int i = 0; i < nums.Length; i++)
        //        dp[i + 1] = (dp[i] == 0 ? 1 : dp[i]) * nums[i];

        //    for (int i = 1; i <= nums.Length; i++)
        //    {
        //        for (int j = i - 1; j >= 0; j--)
        //        {
        //            if (dp[j] == 0)
        //            {
        //                maxProd = Math.Max(Math.Max((dp[i] / 1), 0), maxProd);
        //                break;
        //            }

        //            maxProd = Math.Max(dp[i] / dp[j], maxProd);
        //        }
        //    }

        //    return maxProd;
        //}
    }
}
