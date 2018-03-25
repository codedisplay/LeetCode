using System;

namespace LeetCode
{
    public class MaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            int numsLength = nums.Length;
            // TODO: use sort algorithm and sort array nums
            System.Array.Sort(nums);

            // As min count of nums is 3 
            return Math.Max(
                nums[numsLength - 3] * nums[numsLength - 2] * nums[numsLength - 1],
                nums[0] * nums[1] * nums[numsLength - 1]);
        }
    }
}
