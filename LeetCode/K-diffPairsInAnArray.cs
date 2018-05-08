namespace LeetCode
{
    public class K_diffPairsInAnArray
    {
        public int FindPairs(int[] nums, int k)
        {
            System.Array.Sort(nums);

            int totalpairs = 0;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] - nums[j] == k)
                    {
                        totalpairs++;
                        break;
                    }
                }
                while (i > 0 && nums[i] == nums[i - 1])
                    i--;
            }

            return totalpairs;
        }
    }
}
