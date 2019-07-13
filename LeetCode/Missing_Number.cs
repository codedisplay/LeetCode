namespace LeetCode
{
    public class Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            int totalSum = nums.Length * (nums.Length + 1) / 2, currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
                currentSum += nums[i];

            return totalSum - currentSum;
        }
    }
}
