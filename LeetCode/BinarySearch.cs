namespace LeetCode
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            // CONFIRM: use Binary Search algorithm?
            if (nums.Length != 0 && target >= nums[0] && target <= nums[nums.Length - 1])
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                        return i;
                }

            return -1;
        }
    }
}
