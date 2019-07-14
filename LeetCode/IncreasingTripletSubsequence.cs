using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
                return false;

            int first = nums[0], second = nums[0], i = 0;

            while (first == second && i < nums.Length)
            {
                if (nums[i] > first)
                    second = nums[i];
                else if (nums[i] < first)
                {
                    first = nums[i];
                    second = first;
                }
                i++;
            }

            while (i < nums.Length)
            {
                if (nums[i] > second)
                    return true;
                else if (nums[i] > first)
                    second = Math.Min(nums[i], second);
                else if (nums[i] < first)
                {
                    first = nums[i];
                }

                i++;
            }

            return false;
        }
    }
}
