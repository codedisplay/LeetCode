using System.Text;

namespace LeetCode
{
    public class RomantoInteger
    {
        public int RomanToInt(string s)
        {
            string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            int num = 0;

            for (int i = 0; i < s.Length; i++)
            {
                string oneCharString = s.Substring(i,1);
                string twoCharString = i < s.Length - 1 ? s.Substring(i, 2) : string.Empty; 
                int j = values.Length - 1;

                while (romans[j] != oneCharString && romans[j] != twoCharString)
                    j--;

                num += values[j];

                if (romans[j] == twoCharString)
                    i++;
            }

            return num;
        }
    }
}
