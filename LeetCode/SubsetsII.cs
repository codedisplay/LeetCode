using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<int> current = new List<int>();
            Array.Sort(nums);

            Helper(current, nums.Clone() as int[], 0, ref list);

            return list;
        }

        private void Helper(List<int> current, int[] lookup, int startIndex, ref IList<IList<int>> list)
        {
            list.Add(new List<int>(current));

            int? prev = null;
            for (int i = startIndex; i < lookup.Length; i++)
            {
                if ((!prev.HasValue || prev != lookup[i]))
                {
                    current.Add(lookup[i]);

                    Helper(current, lookup, i + 1, ref list);

                    current.RemoveAt(current.Count - 1);
                    prev = lookup[i];
                }
            }
        }
    }
}
