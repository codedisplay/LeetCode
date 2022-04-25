using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
			var map = new Dictionary<int, int>();
			map[0] = -1;
			int maxlen = 0, count = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				count += nums[i] == 1 ? 1 : -1;

				if (map.ContainsKey(count))
				{
					maxlen = Math.Max(maxlen, i - map[count]);
				}
				else
				{
					map[count] = i;
				}
			}
			return maxlen;
		}
    }
}
