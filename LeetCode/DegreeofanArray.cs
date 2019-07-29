using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DegreeofanArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;
            
            Dictionary<int, int[]> dic = new Dictionary<int, int[]>();// nums[i], {startIndex, Count}
            int degree = 1, minLen = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]][1]++;
                    degree = Math.Max(dic[nums[i]][1], degree);
                }
                else
                    dic.Add(nums[i], new int[2] { i, 1 });

            if (degree == 1)
                return 1;

            for (int i = nums.Length - 1; i >= 0; i--)
                if (dic.ContainsKey(nums[i]) && dic[nums[i]][1] == degree && dic[nums[i]][0] != i)
                {
                    minLen = Math.Min(i - dic[nums[i]][0], minLen);
                    dic.Remove(nums[i]);
                }
           
            return minLen + 1;
        }
    }
}
