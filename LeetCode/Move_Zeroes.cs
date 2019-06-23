namespace LeetCode
{
    public class Move_Zeroes
    {
        //Input: [0,1,0,3,12]
        //Output: [1,3,12,0,0]
        public void MoveZeroes(int[] nums)
        {
            int left = 0, i = 0;

            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    nums[left] = nums[i];
                    left++;
                }

                i++;
            }

            while (left < nums.Length)
            {
                nums[left] = 0;
                left++;
            }
        }
    }
}
