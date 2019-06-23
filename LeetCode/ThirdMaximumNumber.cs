namespace LeetCode
{
    public class ThirdMaximumNumber
    {

        public int ThirdMax(int[] nums)
        {
            int?[] arr = new int?[3];// values further saved in decreasing order

            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[2] == null || nums[i] > arr[2])
                    InsertGreaterValue(arr, nums[i]);
            }

            return  (int) (arr[2] == null ? arr[0] : arr[2]);
        }

        private void InsertGreaterValue(int?[] arr, int? val)
        {
            // for k-th max use binary search to find the index
            if (arr[0] == null || arr[0] == val)
                arr[0] = val;
            else if (val > arr[0])
            {
                arr[2] = arr[1];
                arr[1] = arr[0];
                arr[0] = val;
            }
            else if (arr[1] == null || arr[1] == val)
                arr[1] = val;
            else if (val > arr[1])
            {
                arr[2] = arr[1];
                arr[1] = val;
            }
            else 
                arr[2] = val;
        }
    }
}
