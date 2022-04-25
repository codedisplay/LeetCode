using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindNumbersWithEvenNumberofDigits
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];
                int digitCount = 0;

                while (curr != 0)
                {
                    curr = curr / 10;
                    digitCount++;
                }

                if (digitCount % 2 == 0)
                    count++;
            }

            return count;
        }
    }
}
