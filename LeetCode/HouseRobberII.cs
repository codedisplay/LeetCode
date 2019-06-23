using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            return Math.Max(Rob(nums, 0, new Dictionary<int, int>(), true), Rob(nums, 1, new Dictionary<int, int>()));
        }

        public int Rob(int[] nums, int i, Dictionary<int, int> dp, bool isFirstRobbed = false)
        {
            if (i >= nums.Length ||  i == nums.Length - 1 && isFirstRobbed)
                return 0;

            if (dp.ContainsKey(i))
                return dp[i];

            int secondNext = Rob(nums, i + 2, dp, isFirstRobbed);
            int thirdNext = Rob(nums, i + 3, dp, isFirstRobbed);

            int current = nums[i] + Math.Max(secondNext, thirdNext);
            int next = Rob(nums, i + 1, dp, isFirstRobbed);

            dp[i] = Math.Max(current, next);

            return dp[i];
        }
    }
}
