using System;

namespace LeetCode
{
    public class ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int numLength = nums.Length;
            int maxFromLeft = int.MinValue, minFromRight = int.MaxValue;
            int strtSubArrIndex = -1, endSubArrIndex = -1;

            for (int i = 0; i < numLength; i++)
            {
                maxFromLeft = Math.Max(maxFromLeft, nums[i]);
                minFromRight = Math.Min(minFromRight, nums[numLength - i - 1]);

                if (nums[i] < maxFromLeft)
                    endSubArrIndex = i;
                if (nums[numLength - i - 1] > minFromRight)
                    strtSubArrIndex = numLength - i - 1;
            }

            if (strtSubArrIndex == -1)
                return 0;

            return endSubArrIndex - strtSubArrIndex + 1;
        }

        //public int FindUnsortedSubarray(int[] nums)
        //{
        //    int numLength = nums.Length;

        //    int totalMin = nums[numLength - 1];
        //    int totalMax = nums[0];

        //    for (int i = 0; i < numLength/2; i++)
        //    {
        //        if (nums[i] < totalMin)
        //            totalMin = nums[i];

        //        if (nums[numLength-1 - i] < totalMin)
        //            totalMin = nums[numLength-1 - i];

        //        if (nums[i] > totalMax)
        //            totalMax = nums[i];

        //        if (nums[numLength -1- i] > totalMax)
        //            totalMax = nums[numLength-1 - i];
        //    }

        //    int strtSubArrIndex = 0;
        //    int endSubArrIndex = numLength - 1;

        //    while (strtSubArrIndex < endSubArrIndex)
        //    {
        //        if (nums[strtSubArrIndex] <= nums[endSubArrIndex] && 
        //            nums[strtSubArrIndex]<= totalMin && nums[endSubArrIndex] >= totalMax)
        //        {
        //            if (nums[strtSubArrIndex] <= nums[strtSubArrIndex + 1])
        //                strtSubArrIndex++;
        //            if (nums[endSubArrIndex - 1] <= nums[endSubArrIndex])
        //                endSubArrIndex--;
        //        }
        //        else
        //        {
        //            break;
        //            //if (nums[strtSubArrIndex] <= nums[strtSubArrIndex])
        //            //    strtSubArrIndex++;
        //            //while (nums[endSubArrIndex - 1] <= nums[endSubArrIndex])
        //            //    endSubArrIndex--;

        //            //return endSubArrIndex - strtSubArrIndex + 1;
        //        }
        //    }

        //    return endSubArrIndex > 0 ? endSubArrIndex - strtSubArrIndex + 1 : 0;
        //}
        //public int FindUnsortedSubarray(int[] nums)
        //{
        //    int numLength = nums.Length;
        //    int strtSubArrIndex = 0, endSubArrIndex = numLength - 1;

        //    while (strtSubArrIndex < endSubArrIndex)
        //    {
        //        if (nums[strtSubArrIndex] <= nums[endSubArrIndex])
        //        {
        //            if (nums[strtSubArrIndex] <= nums[strtSubArrIndex+1])
        //                strtSubArrIndex++;
        //            if (nums[endSubArrIndex - 1] <= nums[endSubArrIndex])
        //                endSubArrIndex--;
        //        }
        //        else
        //        {
        //            break;
        //            //if (nums[strtSubArrIndex] <= nums[strtSubArrIndex])
        //            //    strtSubArrIndex++;
        //            //while (nums[endSubArrIndex - 1] <= nums[endSubArrIndex])
        //            //    endSubArrIndex--;

        //            //return endSubArrIndex - strtSubArrIndex + 1;
        //        }
        //    }

        //    if (strtSubArrIndex >= endSubArrIndex)
        //        return 0;
        //    else
        //        return endSubArrIndex - strtSubArrIndex + 1;
        //}

        //public int FindUnsortedSubarray(int[] nums)
        //{
        //    int numLength = nums.Length;
        //    int strtSubArrIndex = 0, endSubArrIndex = 0;

        //    // Correct strtSubArrIndex if not 0
        //    int i = 0;
        //    while (i < numLength - 1)
        //    {
        //        if (nums[i] <= nums[i + 1])
        //            i++;
        //        else
        //        {
        //            strtSubArrIndex = i;
        //            break;
        //        }
        //    }

        //    // Correct endSubArrIndex if not (nums.Length-1)
        //    i = numLength - 1;
        //    while (i > strtSubArrIndex)
        //    {
        //        if (nums[i - 1] <= nums[i])
        //            i--;
        //        else
        //        {
        //            endSubArrIndex = i;
        //            break;
        //        }
        //    }

        //    return endSubArrIndex > 0 ? endSubArrIndex - strtSubArrIndex + 1 : 0;
        //}
    }
}
