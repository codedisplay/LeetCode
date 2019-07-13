namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, mid = 0;

            while (start <= end)
            {
                mid = (start + end) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return start;// insert position
        }
    }
}
