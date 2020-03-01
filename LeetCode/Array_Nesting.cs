using System.Collections.Generic;

namespace LeetCode
{
    public class Array_Nesting
    {
        public int ArrayNesting(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int currentMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int val = GetArrayNestingCount(nums, i, dic);

                if (val > currentMax) currentMax = val;
            }

            return currentMax;
        }

        public int GetArrayNestingCount(int[] nums, int currentIndex, Dictionary<int, int> dic)
        {
            if (dic.ContainsKey(currentIndex))
                return dic[currentIndex];

            dic[currentIndex] = 1+ GetArrayNestingCount(nums, nums[currentIndex], dic);

            return 0;
        }
    }
}
