using System;

namespace LeetCode
{
    public class NumberOfLongestIncreasingSubsequence
    {
        public int FindNumberOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int[] lengthArr = new int[nums.Length];//array for tracking len of increasing sub array
            int[] countArr = new int[nums.Length];// list for tracking no. of longest seq's
            lengthArr[0] = 1;
            countArr[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                lengthArr[i] = 1;
                countArr[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (lengthArr[j] + 1 > lengthArr[i])
                        {
                            lengthArr[i] = lengthArr[j] + 1;
                            countArr[i] = countArr[j];
                        }
                        else if (lengthArr[j] + 1 == lengthArr[i])
                        {
                            countArr[i] += countArr[j];
                        }
                    }
                }
            }

            int maxLength = 1, num = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (lengthArr[i] > maxLength)
                {
                    maxLength = lengthArr[i];
                    num = countArr[i];
                }
                else if (lengthArr[i] == maxLength)
                    num += countArr[i];
            }

            return num;
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
