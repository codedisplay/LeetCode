using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> values = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])// avoid duplicates
                    continue;

                int twoSumTarget = -nums[i];
                int start = i + 1;
                int end = nums.Length - 1;  

                while (start < end)
                {
                    int current = nums[start] + nums[end];

                    if (current == twoSumTarget)
                    {
                        values.Add(new List<int> { nums[i], nums[start++], nums[end--] });

                        while (start < end && nums[start] == nums[start - 1]) start++;// avoid duplicates

                        while (start < end && nums[end] == nums[end + 1]) end--;// avoid duplicates
                    }
                    else if (current > twoSumTarget)
                        end--;
                    else
                        start++;
                }
            }

            return values;
        }


        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    IList<IList<int>> values = new List<IList<int>>();
        //    Array.Sort(nums);

        //    for (int i = 0; i < nums.Length - 2; i = GetDistinctNext(nums, i, true))
        //    {
        //        TwoSum(nums, -nums[i], i + 1, nums.Length - 1, values);
        //    }

        //    return values;
        //}

        //public void TwoSum(int[] nums, int sum, int start, int end, IList<IList<int>> values)
        //{
        //    while (start < end)
        //    {
        //        int current = nums[start] + nums[end];

        //        if (current == sum)
        //        {
        //            values.Add(new List<int> { -sum, nums[start], nums[end] });
        //            start = GetDistinctNext(nums, start, true);
        //            end = GetDistinctNext(nums, end, false);
        //        }
        //        else if (current < sum)
        //        {
        //            start = GetDistinctNext(nums, start, true);
        //        }
        //        else if (current > sum)
        //        {
        //            end = GetDistinctNext(nums, end, false);
        //        }
        //    }
        //}

        //public int GetDistinctNext(int[] nums, int i, bool isIncrement)
        //{
        //    int next = i;

        //    while (next > -1 && next < nums.Length && nums[i] == nums[next])
        //    {
        //        next = isIncrement ? next + 1 : next - 1;
        //    }

        //    return next;
        //}

    }
}
