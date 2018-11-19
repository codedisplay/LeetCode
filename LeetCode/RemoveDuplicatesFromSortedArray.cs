namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[len] = nums[i - 1];
                    len++;
                }
            }

            if (nums.Length > 0)
            {
                nums[len] = nums[nums.Length - 1];
                len++;
            }

            return len;
        }
    }
}
