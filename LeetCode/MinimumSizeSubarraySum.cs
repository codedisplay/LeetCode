using System;

namespace LeetCode
{
    public class MinimumSizeSubarraySum
    {
        // TODO: remove using dp and compute inline
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int minLength = nums.Length +1, left = 0, right = 1;
            int[] dp = new int[nums.Length + 1];

            for (int i = 1; i <= nums.Length; i++)
                dp[i] = nums[i - 1] + dp[i - 1];

            while (left < right && right <= nums.Length)
            {
                var current = dp[right] - dp[left];

                if (current >= s)
                {
                    minLength = Math.Min(right - left, minLength);
                    left++;
                }
                else
                    right++;
            }

            return minLength > nums.Length ? 0 : minLength;
        }
    }
}
