namespace LeetCode
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[start] <= nums[mid])//left is in asc order
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

            return -1;
        }

        // working - find pivot -> perform binary search on pivot's left or right side
        //public int Search(int[] nums, int target)
        //{
        //    if (nums == null || nums.Length == 0)
        //        return -1;

        //    int size = nums.Length;
        //    int pivotIndex = FindPivotInSortedArray(nums);

        //    if (target >= nums[0] && target <= nums[pivotIndex])
        //        return BinarySearch(nums, 0, pivotIndex, target);
        //    else if (pivotIndex < size - 1 && target >= nums[pivotIndex + 1]
        //        && target <= nums[size - 1])
        //        return BinarySearch(nums, pivotIndex + 1, size - 1, target);

        //    return -1;
        //}

        //public int FindPivotInSortedArray(int[] nums)
        //{
        //    if (nums == null || nums.Length == 0)
        //        return -1;

        //    int left = 0, right = nums.Length - 1;
        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (mid + 1 >= nums.Length || nums[mid] > nums[mid + 1])
        //            return mid;
        //        else if (nums[left] <= nums[mid])
        //            left = mid + 1;
        //        else
        //            right = mid - 1;
        //    }

        //    return -1;
        //}

        //private int BinarySearch(int[] nums, int left, int right, int target)
        //{
        //    if (nums == null || nums.Length == 0)
        //        return -1;

        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (nums[mid] == target)
        //            return mid;
        //        else if (nums[mid] < target)
        //            left = mid + 1;
        //        else
        //            right = mid - 1;
        //    }

        //    return -1;
        //}
    }
}
