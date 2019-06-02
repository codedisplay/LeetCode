using System;

namespace LeetCode
{
    public class LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int currentMax = 1, currentSeqCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    currentSeqCount++;
                    currentMax = Math.Max(currentSeqCount, currentMax);
                }
                else
                    currentSeqCount = 1;
            }

            return currentMax;
        }
    }
}
