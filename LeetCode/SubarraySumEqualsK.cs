using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class SubarraySumEqualsK
    {
        // Implementation for non-continous sub array with specific sum
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            Array.Sort(nums);

            int count = GetCount(nums, nums.Length - 1, 0, k, dic);

            return count;
        }

        public int GetCount(int[] nums, int endIndex, int currentSum, int sum, Dictionary<string, int> dic)
        {
            int count = 0;

            string dicKey = endIndex + "," + currentSum;

            if (dic.ContainsKey(dicKey))
                return dic[dicKey];

            if (currentSum == sum)
                return 1;

            if (currentSum > sum)
                return 0;

            if (endIndex < 0)
                return 0;

            int withSum = GetCount(nums, endIndex - 1, currentSum + nums[endIndex], sum, dic);

            int withOutSum = GetCount(nums, endIndex - 1, currentSum, sum, dic);

            count = withSum + withOutSum;

            dic[dicKey] = count;

            return count;
        }
    }
}
