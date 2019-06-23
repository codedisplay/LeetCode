using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindAllNumbersDisappearedinanArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentVal = Math.Abs(nums[i]);

                if (nums[currentVal - 1] > 0)
                    nums[currentVal - 1] = -nums[currentVal - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    list.Add(i +1);
            }

            return list;
        }
    }
}
