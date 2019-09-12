namespace LeetCode
{
    public class SearchInRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                    return true;

                if (nums[start] == nums[mid])
                {
                    while (start <= mid && nums[start] == nums[mid])
                        start++;
                }
                else if (nums[mid] == nums[end])
                {
                    while (mid < end && nums[mid] == nums[end])
                        end--;
                }
                else if (nums[start] < nums[mid])//left is in asc order
                {
                    if (nums[start] <= target && nums[mid] > target)// if target is in left range
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else //right should be in asc order
                {
                    if (nums[mid] < target && nums[end] >= target)// if target is in right range
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }

            return false;
        }

    }
}
