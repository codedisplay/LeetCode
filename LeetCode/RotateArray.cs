namespace LeetCode
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = nums.Length == 0 ? 0 : k % nums.Length;

            if (k == 0)
                return;

            int count = 0, i = 0;
            while (count != nums.Length)
                count = Rotate(nums, k, i++, count);
        }

        private int Rotate(int[] nums, int k, int start, int count)
        {
            int to = start, prev = nums[start];

            do
            {
                to = (to + k) % nums.Length;

                int temp = nums[to];
                nums[to] = prev;

                prev = temp;
                count++;
            } while (to != start);

            return count;
        }
    }
}
