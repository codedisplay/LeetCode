using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Largest_Divisible_Subsetcs
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            IList<int> list = new List<int>();

            if (nums.Length == 0)
                return list;

            Array.Sort(nums);// sort in asc

            int[] dp = new int[nums.Length];// for storing the computed sequence count
            int[] arr = new int[nums.Length];// for storing the previous val in the sequence from current

            dp[0] = 1;
            arr[0] = -1;

            int currentMaxSeqCount = 1, currentMaxEndIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = 1;
                arr[i] = -1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        arr[i] = j;

                        if (dp[i] > currentMaxSeqCount)
                        {
                            currentMaxSeqCount = dp[i];
                            currentMaxEndIndex = i;
                        }
                    }
                }
            }

            list.Add(nums[currentMaxEndIndex]);
            while (arr[currentMaxEndIndex] != -1)
            {
                int prevSeqValIndex = arr[currentMaxEndIndex];
                list.Add(nums[prevSeqValIndex]);
                currentMaxEndIndex = prevSeqValIndex;
            }

            return list;
        }
    }
}
