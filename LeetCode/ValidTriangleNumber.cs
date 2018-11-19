using System;

namespace LeetCode
{
    public class ValidTriangleNumber
    {
        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int startIndex = 0;

            while (startIndex < nums.Length && nums[startIndex] == 0)
                startIndex++;

            if (nums.Length - startIndex < 3)
                return 0;

            int sides = 0;

            for (int i = startIndex; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int low = j + 1;
                    int high = nums.Length - 1;

                    while (low <= high)
                    {
                        if (nums[i] + nums[j] <= nums[high])
                            high--;
                        else if (nums[j] - nums[i] >= nums[low])
                            low++;
                        else
                        {
                            sides += high - low + 1;
                            low = high + 1;
                        }

                    }
                }
            }

            return sides;
        }

        //public static int TriangleNumber(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int startIndex = 0;

        //    while (startIndex < nums.Length && nums[startIndex] == 0)
        //        startIndex++;

        //    if (nums.Length - startIndex < 3)
        //        return 0;

        //    int sides = 0;

        //    for (int i = startIndex; i < nums.Length - 2; i++)
        //    {
        //        int low = i + 1;
        //        int high = nums.Length - 1;

        //        while (low < high)
        //        {
        //            // Condition for valid triangle a+b > c > a-b
        //            if (nums[low] + nums[high] <= nums[i])
        //                high--;
        //            else if (nums[high] - nums[low] >= nums[i])
        //                low++;
        //            else
        //            {
        //                sides += high - low;
        //                low = high;
        //            }

        //        }
        //    }

        //    return sides;
        //}
    }
}
