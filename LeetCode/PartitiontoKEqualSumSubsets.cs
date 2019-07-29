using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class PartitiontoKEqualSumSubsets
    {
        bool[] used;
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (nums.Length < k || nums.Length == 0)
                return false;
            if (k == 1)
                return true;

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            if (sum % k != 0)
                return false;

            Array.Sort(nums);

            used = new bool[nums.Length];
            used[nums.Length - 1] = true;
            return CanPartitionKSubsetsHelper(nums, k, 0, -1, nums.Length - 2, nums[nums.Length - 1], sum / k); ;
        }

        public bool CanPartitionKSubsetsHelper(int[] nums, int k, int currentK, int index, int endIndex, int currentSum, int target)
        {
            //if (currentSum == target)
            //{
            //    currentK++;

            //    if (currentK != k)
            //    {

            //    }
            //}

            return false;
        }
        //public bool CanPartitionKSubsets(int[] nums, int k)
        //{
        //    if (nums.Length < k || nums.Length == 0)
        //        return false;
        //    if (k == 1)
        //        return true;

        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //        sum += nums[i];

        //    if (sum % k != 0)
        //        return false;

        //    Array.Sort(nums);

        //    used = new bool[nums.Length];
        //    used[nums.Length - 1] = true;
        //    return CanPartitionKSubsetsHelper(nums, k, 0, -1, nums.Length - 2, nums[nums.Length - 1], sum / k); ;
        //}

        //public bool CanPartitionKSubsetsHelper(int[] nums, int k, int currentK, int index, int endIndex, int currentSum, int target)
        //{
        //    if (currentSum == target)
        //    {
        //        currentK++;

        //        if (currentK == k && used.Length == nums.Length)
        //            return true;

        //        used[endIndex] = true;
        //        var res = CanPartitionKSubsetsHelper(nums, k, currentK, -1, endIndex - 1, nums[endIndex], target);
        //        used[endIndex] = false;
        //        return res;
        //    }
        //    else if (currentSum > target)
        //        return false;

        //    if (endIndex < 0 || index > endIndex)
        //        return false;

        //    var nextIndex = index + 1;

        //    while (used[nextIndex] && nextIndex < endIndex)
        //        nextIndex++;

        //    if (used[nextIndex])
        //        return false;

        //    //include current
        //    used[nextIndex] = true;

        //    if (nextIndex == 5)
        //    {
        //        used[nextIndex] = true;
        //    }

        //    var isValid = CanPartitionKSubsetsHelper(nums, k, currentK, nextIndex + 1, endIndex, currentSum + nums[nextIndex], target);

        //    used[nextIndex] = false;

        //    if (isValid)
        //        return true;

        //    //exclude current
        //    return CanPartitionKSubsetsHelper(nums, k, currentK, nextIndex + 1, endIndex, currentSum, target);
        //}
    }
}
