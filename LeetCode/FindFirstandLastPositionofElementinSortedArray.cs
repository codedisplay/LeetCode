namespace LeetCode
{
    public class FindFirstandLastPositionofElementinSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
                return new int[] { -1, -1 };

            int[] arr = new int[2];

            arr[0] = BinarySearch(nums, target, 0, nums.Length - 1);

            if (arr[0] == -1)
                return new int[] { -1, -1 };

            arr[1] = BinarySearch(nums, target, arr[0], nums.Length - 1, false);

            return arr;
        }

        public int BinarySearch(int[] nums, int target, int start, int end, bool findLeftIndex = true)
        {
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] > target)
                    end = mid - 1;
                else if (nums[mid] < target)
                    start = mid + 1;
                else if (findLeftIndex)
                {
                    if (mid == 0 || nums[mid] != nums[mid - 1])
                        return mid;
                    else
                        end = mid - 1;
                }
                else
                {
                    if (mid == nums.Length-1 || nums[mid] != nums[mid + 1])
                        return mid;
                    else
                        start = mid + 1;
                }
            }

            return -1;
        }

        //public int[] SearchRange(int[] nums, int target)
        //{
        //    if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
        //        return new int[] { -1, -1 };

        //    int containsIndex = BinarySearch(nums, target);

        //    if (containsIndex != -1)
        //        return SearchRange(nums, target, containsIndex);

        //    return new int[] { -1, -1 };
        //}

        //public int BinarySearch(int[] nums, int target)
        //{
        //    int start = 0, end = nums.Length - 1;

        //    while (start <= end)
        //    {
        //        int midValue = nums[(start + end) / 2];

        //        if (nums[midValue] == target)
        //            return midValue;
        //        else if (nums[midValue] < target)
        //            start = midValue + 1;
        //        else
        //            end = midValue - 1;
        //    }

        //    return -1;
        //}

        //public int[] SearchRange(int[] nums, int target, int containsIndex)
        //{
        //    //TODO
        //    return new int[] { -1, -1 };
        //}
    }
}
