using System;

namespace LeetCode
{
    public class First_Missing_Positive
    {
        public int FirstMissingPositive(int[] nums)
        {
            bool isOneFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    isOneFound = true;
                else if (nums[i] < 1 || nums[i] > nums.Length)
                    nums[i] = 1;
            }

            if (!isOneFound)
                return 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int curr = Math.Abs(nums[i]);

                if (curr <= nums.Length && nums[curr - 1] > 0)
                    nums[curr - 1] = -nums[curr - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    return i + 1;
            }

            return nums.Length + 1;
        }

        // With using Array Memory - submitted
        //public int FirstMissingPositive(int[] nums)
        //{
        //    int[] arr = new int[nums.Length];

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > 0 && nums[i] <= nums.Length)
        //            arr[nums[i]-1]++;
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == 0)
        //            return i + 1;
        //    }

        //    return nums.Length + 1;
        //}

        // With sorting - submitted
        //public int FirstMissingPositive(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int val = 1;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > 0)
        //            if (val == nums[i])
        //                val++;
        //            else if (val < nums[i])
        //                return val;
        //    }

        //    return val;
        //}
    }
}
