namespace LeetCode
{
    public class NumArray
    {
        private readonly int[] dp;

        public NumArray(int[] nums)
        {
            dp = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                dp[i + 1] = nums[i] + dp[i];
            }
        }

        public int SumRange(int i, int j)
        {
            return dp[j + 1] - dp[i];
        }
    }
}
