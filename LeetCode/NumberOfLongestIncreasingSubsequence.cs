using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class NumberOfLongestIncreasingSubsequence
    {
        public int FindNumberOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int[] dp = new int[nums.Length];//array for tracking len of increasing sub array
            List<int> countArr = new List<int> { 0 };// list for tracking no. of longest seq's

            Array.Fill(dp, 1);

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (dp[j] + 1 >= dp[i])
                        {
                            dp[i] = dp[j] + 1;

                            if (countArr.Count == dp[j])
                                countArr.Add(0);

                            countArr[dp[j]]++;
                        }
                    }
                }
            }

            return countArr[countArr.Count - 1] == 0 ? nums.Length : countArr[countArr.Count - 1];
        }

        //public int FindNumberOfLIS(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return 0;

        //    int[] lis = new int[nums.Length];//array for tracking length of increasing sub array
        //    Array.Fill(lis, 1);
        //    int currentMax = 1, totalMaxCount = 1;

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        int currentMaxCount = 1;
        //        bool isCurrentModified = false ;

        //        for (int j = 0; j < i; j++)
        //        {
        //            if (nums[j] == nums[i])
        //            {
        //                if (lis[i] == currentMax)
        //                {
        //                    isCurrentModified = true;
        //                    currentMaxCount++;
        //                }
        //            }
        //            else if (nums[j] < nums[i])
        //            {
        //                if (lis[j] + 1 >= lis[i])
        //                {
        //                    //if(lis[j] + 1 > )
        //                    lis[i] = lis[j] + 1;

        //                    if (lis[i] > currentMax)
        //                    {
        //                        currentMax = lis[i];
        //                        currentMaxCount = 1;
        //                        isCurrentModified = true;
        //                    }
        //                    else if (lis[i] == currentMax)
        //                    {
        //                        currentMaxCount++;
        //                        isCurrentModified = true;
        //                    }
        //                }
        //            }
        //        }
        //        if (isCurrentModified)
        //            totalMaxCount = currentMaxCount;
        //        //totalMaxCount = Math.Max(currentMaxCount,totalMaxCount);
        //    }

        //    return totalMaxCount;
        //}

        //public int FindNumberOfLIS(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return 0;

        //    var lengthArr = new int[nums.Length];
        //    List<int>[] subSequenceArr = new List<int>[nums.Length]; ;

        //    var waysArr = new int[nums.Length];

        //    lengthArr[0] = 1;
        //    waysArr[0] = 1;
        //    int maxLength = 1;

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        lengthArr[i] = 1;
        //        waysArr[i] = 1;

        //        for (int j = i-1; j >= 0; j--)
        //        {
        //            if (nums[j] < nums[i])
        //            {
        //                if (subSequenceArr[i] == null)
        //                {
        //                    subSequenceArr[i] = new List<int>();
        //                }

        //                if (lengthArr[j] + 1 == lengthArr[i])
        //                {
        //                    waysArr[i]++;
        //                    subSequenceArr[i].Add(j);
        //                }
        //                else if (lengthArr[j] + 1 > lengthArr[i])
        //                {
        //                    waysArr[i] = 1;
        //                    subSequenceArr[i].Add(j);
        //                }

        //                lengthArr[i] = Math.Max(lengthArr[j] + 1, lengthArr[i]);



        //                maxLength = Math.Max(lengthArr[i], maxLength);

        //            }
        //        }
        //    }

        //    int occurences = 0;
        //    //int maxValue = lengthArr.Max();
        //    int[] indexes = lengthArr.Select((b, i) => b == maxLength ? i : -1).Where(i => i != -1).ToArray();

        //    foreach (var index in indexes)
        //    {
        //        occurences = occurences + waysArr[index];
        //    }

        //    return occurences;
        //}
    }
}
