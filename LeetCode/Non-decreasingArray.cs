namespace LeetCode
{
    public class Non_decreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            bool isFound = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                    if (!isFound)
                    {
                        if ((i != 1 && nums[i - 2] > nums[i]) &&
                            (i != nums.Length - 1 && nums[i - 2] > nums[i + 1]))
                            return false;
                        isFound = true;
                    }
                    else
                        return false;
            }

            return true;
        }
    }
}
