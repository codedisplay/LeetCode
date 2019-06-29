using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TargetSum
    {
        // Submitted
        // TODO: reduce memory to O(nums.length+1)
        public int FindTargetSumWays(int[] nums, int S)
        {
            Dictionary<string, int> dp = new Dictionary<string, int>();
            int total = 0;

            return FindTargetSumWays(nums, S, nums.Length - 1, 0, dp, ref total);
        }

        public int FindTargetSumWays(int[] nums, int S, int endIndex, int currentSum, Dictionary<string, int> dp, ref int total)
        {
            if (endIndex < 0)
                return currentSum == S ? 1 : 0;

            string lookup = $"{endIndex}-{currentSum}";

            if (dp.ContainsKey(lookup))
                return dp[lookup];

            // + current val
            int plusCurrent = FindTargetSumWays(nums, S, endIndex - 1, currentSum + nums[endIndex], dp, ref total);

            // - current val
            int minusCurrent = FindTargetSumWays(nums, S, endIndex - 1, currentSum - nums[endIndex], dp, ref total);

            dp[lookup] = plusCurrent + minusCurrent;

            return dp[lookup];
        }
    }
}
