using System;

namespace LeetCode
{
    public class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];

            int currentSum = nums[0], maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum += nums[i];

                if (nums[i] > currentSum)
                    currentSum = nums[i];

                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;

        }
        //public int MaxSubArray(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return 0;
        //    else if (nums.Length == 1)
        //        return nums[0];

        //    int currentMax = nums[0];

        //    int[] sumArr = new int[nums.Length + 1];
        //    int lowest = nums[0] > 0 ? 0 : 1, highest = 1;
        //    sumArr[0] =  0;
        //    sumArr[1] = nums[0];

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        sumArr[i + 1] = sumArr[i] + nums[i];

        //        if (sumArr[i + 1] <= sumArr[lowest])
        //        {
        //            currentMax = Math.Max(currentMax, highest == lowest ? nums[lowest] : sumArr[highest+1] - sumArr[lowest+1]);

        //            lowest = i;
        //            highest = i + 1 < nums.Length - 1 ? i + 1 : i;
        //        }
        //        else if (sumArr[i + 1] > sumArr[highest])
        //        {
        //            highest = i;
        //            currentMax = Math.Max(currentMax, highest == lowest ? nums[lowest] : sumArr[highest + 1] - sumArr[lowest + 1]);
        //        }
        //    }

        //    currentMax = Math.Max(currentMax, highest == lowest ? nums[lowest] : sumArr[highest + 1] - sumArr[lowest + 1]);

        //    return currentMax;
        //}
    }
}
