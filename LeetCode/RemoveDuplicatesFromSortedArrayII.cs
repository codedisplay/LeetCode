namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            int len = 0;

            if (nums[0] != nums[1] || nums[1] != nums[2])
            {
                nums[len] = nums[0];
                len++;

                if (nums[1] != nums[2])
                {
                    nums[len] = nums[1];
                    len++;
                }
            }

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i] && i != 2)
                {
                    if (nums[i - 2] == nums[i - 1])
                    {
                        nums[len] = nums[i - 1];
                        len++;
                    }

                    nums[len] = nums[i - 1];
                    len++;
                }
            }

            if (nums[nums.Length - 2] == nums[nums.Length - 1])
            {
                nums[len] = nums[nums.Length - 1];
                len++;
                nums[len] = nums[nums.Length - 1];
                len++;
            }
            else
            {
                nums[len] = nums[nums.Length - 1];
                len++;
            }

            return len;
        }
    }
}
