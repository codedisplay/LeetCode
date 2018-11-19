namespace LeetCode
{
    public class FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            int sum = 0, i;

            for (i = 0; i < nums.Length; i++)
                sum += nums[i];

            for (i = nums.Length - 1; i > 0; i--)
            {
                sum -= nums[i];

                if (sum == ((i) * ((i) + 1) / 2))
                {
                    return nums[i];
                }
            }

            return nums[0];
        }

    }
}
