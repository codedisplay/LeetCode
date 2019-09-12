using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();
            int[] current = new int[2];

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;

                current[0] = nums[i];

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j != 0 && nums[j] == nums[j - 1])
                        continue;
                    if (nums[i] + nums[j] >= target)
                        return result;
                    current[1] = nums[j];

                    TwoSum(current, nums, j + 1, target - (current[0] + current[1]), result);
                }
            }

            return result;
        }

        private void TwoSum(int[] current, int[] nums, int start, int twoTarget, IList<IList<int>> result)
        {
            int end = nums.Length - 1;

            while (start < end && nums[start] < twoTarget/* && nums[start] <= twoTarget && nums[end] >= twoTarget*/)
            {
                int val = nums[start] + nums[end];

                if (val == twoTarget)
                    result.Add(new List<int> { current[0], current[1], nums[start], nums[end] });

                if (val >= twoTarget)
                {
                    end--;
                    while (start < end && nums[end] == nums[end + 1])
                        end--;
                }
                if (val <= twoTarget)
                {
                    start++;
                    while (start < end && nums[start - 1] == nums[start])
                        start++;
                }

            }
        }
    }
}
