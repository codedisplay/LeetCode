using System;

namespace LeetCode
{
    public class _3Sum_Closest
    {
        //TODO: REDO and fix this
        public int ThreeSumClosest(int[] nums, int target)
        {
            int closest = nums.Length > 2 ? nums[0] + nums[1] + nums[2] : 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i = GetDistinctNext(nums, i, true))
            {
                int sum = TwoSumClosest(nums, target - nums[i], i + 1, nums.Length - 1);

                if (Math.Abs(target - (nums[i] + sum)) < Math.Abs(target - closest))
                {
                    closest = nums[i] + sum;

                    if (closest == target)
                        return closest;
                }
            }

            return closest;
        }

        public int TwoSumClosest(int[] nums, int target, int start, int end)
        {
            int closestSum = nums[start] + nums[end];

            while (start < end && start > 0 && end < nums.Length)
            {
                int current = nums[start] + nums[end];

                if (Math.Abs(target - current) < Math.Abs(target - closestSum))
                    closestSum = current;

                if (current == target)
                {
                    start = GetDistinctNext(nums, start, true);
                    end = GetDistinctNext(nums, end, false);
                }
                else if (current < target)
                {
                    start = GetDistinctNext(nums, start, true);
                }
                else if (current > target)
                {
                    end = GetDistinctNext(nums, end, false);
                }

            }

            return closestSum;
        }

        public int GetDistinctNext(int[] nums, int i, bool isIncrement)
        {
            int next = isIncrement ? i + 1 : i - 1; ;

            while (next > -1 && next < nums.Length - 2 && nums[i] == nums[next] && nums[next] == nums[i + 2])
            {
                next = isIncrement ? next + 1 : next - 1;
            }

            return next;
        }
    }
}
