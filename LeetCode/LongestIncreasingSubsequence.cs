using System;

namespace LeetCode
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            var lengthArr = new int[nums.Length];
            lengthArr[0] = 1;
            int maxLength = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                lengthArr[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        lengthArr[i] = Math.Max(lengthArr[j] + 1, lengthArr[i]);
                        maxLength = Math.Max(lengthArr[i], maxLength);
                    }
                }
            }

            return maxLength;
        }
    }
}
