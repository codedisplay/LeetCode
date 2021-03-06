﻿using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();

            if (nums.Length == 0)
                return list;

            IList<int> used = new List<int>();
            Permute(nums.Clone() as int[], nums, used, 0, ref list);

            return list;
        }

        public void Permute(int[] nums, int[] generatedNums, IList<int> used, int index, ref IList<IList<int>> list)
        {
            if (index == nums.Length)
            {
                list.Add(generatedNums.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!used.Contains(nums[i]))
                {
                    used.Add(nums[i]);

                    generatedNums[index] = nums[i];
                    Permute(nums, generatedNums, used, index + 1, ref list);

                    used.RemoveAt(used.Count - 1);
                }
            }
        }
    }
}
