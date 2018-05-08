namespace LeetCode
{
    public class Class1
    {
        public static int Perform(string str)
        {
            int totalValue = 0, length = str.Length, i = 0;
            bool isCurrentAdd = true;// only two operation; add and sub// for the sub string it's add

            while (i < length)
            {
                int times = 0, maxCount = 0;

                while (str[i] == ' ')
                    i++;

                if (str[i] == '+' || str[i] == '-')
                {
                    isCurrentAdd = (str[i] == '+');
                    i++;
                }

                while (str[i] == ' ')
                    i++;

                times = str[i] - '0';//char to string conversion
                i++;

                int currentTotal = 0;

                if (i < length - 1 && str[i] == 'd')
                {// mdn format substring
                    i++;

                    maxCount = str[i] - '0';//char to string conversion
                    currentTotal = GetNumbers(times, maxCount);
                }
                else// sub string is number
                    currentTotal = times;

                if (isCurrentAdd)
                    totalValue += currentTotal;
                else
                    totalValue -= currentTotal;

                i++;
            }

            return totalValue;
        }

        public static int GetNumbers(int times, int maxCount)
        {
            int sum = 0;
            System.Random random = new System.Random();

            for (int i = 0; i < times; i++)
                sum += random.Next(0, maxCount + 1);

            return sum;
        }
    }
}
