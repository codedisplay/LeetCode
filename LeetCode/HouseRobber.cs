using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            Dictionary<int, int> dp = new Dictionary<int, int>();

            return Rob(nums, 0, dp);
        }

        public int Rob(int[] nums, int i, Dictionary<int, int> dp)
        {
            if (i >= nums.Length)
                return 0;

            if (dp.ContainsKey(i))
                return dp[i];

            int secondNext = Rob(nums, i + 2, dp);
            int thirdNext = Rob(nums, i + 3, dp);

            int current = nums[i] + Math.Max(secondNext, thirdNext);
            int next = Rob(nums, i + 1, dp);

            dp[i] = Math.Max(current, next);

            return dp[i];
        }
    }
}
