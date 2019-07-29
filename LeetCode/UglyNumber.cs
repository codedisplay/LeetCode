namespace LeetCode
{
    public class UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num < 1)
                return false;

            while (num > 0 && num % 2 == 0)
            {
                num = num / 2;
            }

            while (num > 0 && num % 3 == 0)
            {
                num = num / 3;
            }

            while (num > 0 && num % 5 == 0)
            {
                num = num / 5;
            }

            return num == 1;
        }
    }
}
