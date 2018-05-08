namespace LeetCode
{
    public class JumpGameII
    {
        public int Jump(int[] nums)
        {
            int i = 0, steps = 0, length = nums.Length;

            if (length == 0)
                return 1;

            while (i < length - 1)
            {
                int maxVal = -1, maxToIndex = -1, newIndex = i + 1;

                if (i + nums[i] >= length - 1)
                {
                    steps++;
                    break;
                }

                while (newIndex < length && newIndex - i <= nums[i] && maxVal < length - 1)
                {
                    if (maxVal <= newIndex + nums[newIndex])
                    {
                        maxVal = newIndex + nums[newIndex];
                        maxToIndex = newIndex;
                    }

                    newIndex++;
                }

                i = maxToIndex;
                steps++;
            }

            return steps;
        }
    }
}
