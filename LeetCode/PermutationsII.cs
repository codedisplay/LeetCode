using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();

            if (nums.Length == 0)
                return list;

            Array.Sort(nums);

            bool[] used = new bool[nums.Length];
            Permute(nums.Clone() as int[], nums, used, 0, ref list);

            return list;
        }

        public void Permute(int[] nums, int[] generatedNums, bool[] used, int index, ref IList<IList<int>> list)
        {
            if (index == nums.Length)
            {
                list.Add(generatedNums.ToList());
                return;
            }

            int? prev = null; 

            for (int i = 0; i < nums.Length; i++)
            {
                if (!used[i] && (!prev.HasValue || prev != nums[i]))
                {
                    used[i] = true;

                    generatedNums[index] = nums[i];
                    Permute(nums, generatedNums, used, index + 1, ref list);

                    used[i] = false;

                    prev = nums[i];
                }
            }
        }
    }
}
