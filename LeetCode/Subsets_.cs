using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Subsets_
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Array.Sort(nums);

            Helper(current, nums.Clone() as int[], 0, used, 0, ref list);

            return list;
        }

        private void Helper(List<int> current, int[] lookup, int startIndex, bool[] used, int index, ref IList<IList<int>> list)
        {
            list.Add(new List<int>(current));

            if (index == lookup.Length)
                return;

            for (int i = startIndex; i < lookup.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    current.Add(lookup[i]);

                    Helper(current, lookup, i + 1, used, index + 1, ref list);

                    current.RemoveAt(current.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
}
