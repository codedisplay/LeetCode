using System;

namespace LeetCode
{
    public class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int length = nums.Length;
            int[] arr = new int[length];
            Array.Fill(arr, 1);
            int left = nums[0], right = nums[length - 1];

            for (int i = 1; i < length; i++)
            {
                arr[i] = arr[i] * left;

                int end = length - i - 1;
                arr[end] = arr[end] * right;

                left = left * nums[i];
                right = right * nums[end];
            }

            return arr;
        }
    }
}
