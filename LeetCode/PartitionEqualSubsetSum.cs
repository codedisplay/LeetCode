using System.Collections.Generic;

namespace LeetCode
{
    public class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int totalSum = 0;
            Dictionary<string, bool> dp = new Dictionary<string, bool>();

            for (int i = 0; i < nums.Length; i++)
                totalSum += nums[i];

            if (totalSum % 2 != 0)
                return false;

            return CanPartition(nums, totalSum - nums[nums.Length - 1], nums[nums.Length - 1], nums.Length - 1, dp);
        }

        public bool CanPartition(int[] nums, int currentSum, int excludedSum, int endIndex, Dictionary<string, bool> dp)
        {
            if (currentSum == excludedSum)
                return true;

            if (endIndex < 0 || currentSum < excludedSum)
                return false;

            string lookup = $"{currentSum}-{endIndex}";

            if (dp.ContainsKey(lookup))
                return dp[lookup];

            dp[lookup] =
                CanPartition(nums, currentSum - nums[endIndex], excludedSum + nums[endIndex], endIndex - 1, dp)// Include current
                || CanPartition(nums, currentSum, excludedSum, endIndex - 1, dp);// Exclude Current

            return dp[lookup];
        }
    }
}
