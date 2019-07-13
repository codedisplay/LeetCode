using System;

namespace LeetCode
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int current = 0, ones = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    current++;
                else
                {
                    ones = Math.Max(current, ones);
                    current = 0;
                }
            }

            return Math.Max(current, ones);
        }
    }
}
