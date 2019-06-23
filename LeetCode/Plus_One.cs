namespace LeetCode
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;

            while (i >= 0 && digits[i] == 9)
            {
                digits[i] = 0;
                i--;
            }

            if (i == -1)
            {
                int[] arr = new int[digits.Length + 1];
                arr[0] = 1;
                return arr;
            }

            digits[i] += 1;
            return digits;
        }
    }
}
