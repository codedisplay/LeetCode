namespace LeetCode
{
    public class FindFirstandLastPositionofElementinSortedArray
    {
        //TODO: fix this
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
                return new int[] { -1, -1 };

            int[] arr = new int[2];

            arr[0] = BinarySearch(nums, target, 0, nums.Length - 1);

            if (arr[0] == nums.Length || nums[arr[0]] != target)
                return new int[] { -1, -1 };

            arr[1] = BinarySearch(nums, target, 0, nums.Length - 1, false) - 1;

            return arr;
        }

        public int BinarySearch(int[] nums, int target, int start, int end, bool findLeftIndex = true)
        {
            while (start < end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] > target || (findLeftIndex && nums[mid] == target))
                    end = mid;
                else
                    start = mid + 1;
            }

            return start;
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
