namespace LeetCode
{
    public class ReverseInteger
    {
        //public const Int32 MaxValue = 2147483647;
        //public const Int32 MinValue = -2147483648;

        public int Reverse(int x)
        {
            long val = 0;

            while (x != 0)
            {
                val = val * 10 + x % 10;
                x = x / 10;
            }

            return val > int.MaxValue || val < int.MinValue ? 0 : (int)val;
        }
    }
}
