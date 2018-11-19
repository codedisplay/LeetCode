using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> list = new List<int>();

            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    list.Add(nums[i]);
                }
            }

            return list;
        }
    }
}
