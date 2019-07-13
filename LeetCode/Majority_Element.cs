namespace LeetCode
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int element = 0, count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (element == nums[i])
                {
                    count++;
                }
                else if (count == 0)
                {
                    element = nums[i];
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return element;
        }
    }
}
