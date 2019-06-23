namespace LeetCode
{
    public class Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            int left = 0, right = nums.Length - 1;

            // 1 pass
            for (int i = 0; i < nums.Length && i <= right; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = nums[left];
                    nums[left] = 0;
                    left++;
                }
                else if (nums[i] == 2)
                {
                    nums[i] = nums[right];
                    nums[right] = 2;
                    right--;
                    i--;
                }
            }
        }
    }
}
