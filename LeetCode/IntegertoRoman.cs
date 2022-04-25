using System.Text;

namespace LeetCode
{
    public class IntegertoRoman
    {
        //public string IntToRoman(int num)
        //{
        //    var str = IntToRomanHelper(num);
        //    return str.ToString();
        //}

        //public StringBuilder IntToRomanHelper(int num)
        //{
        //    StringBuilder roman = new StringBuilder();

        //    if (num == 0)
        //        return roman;
        //    else if (num <= 3)
        //    {
        //        var digits = num % 5;

        //        for (int i = 0; i < digits; i++)
        //        {
        //            roman.Append("I");
        //        }
        //    }
        //    else if (num <= 8)
        //    {
        //        var differnce = num - 5;
        //        if (differnce <= 0)
        //        {
        //            roman.Append(IntToRomanHelper(System.Math.Abs(differnce)));
        //            roman.Append("V");
        //        }
        //        else
        //        {
        //            roman.Append("V");
        //            roman.Append(IntToRomanHelper(differnce));
        //        }
        //    }
        //    else 

        //    return roman;
        //}

        public string IntToRoman(int num)
        {
            string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            StringBuilder str = new StringBuilder();

            for (int i = romans.Length - 1; i >= 0; i--)
            {
                while(num >= values[i])
                {
                    str.Append(romans[i]);
                    num = num - values[i];
                }
            }

            return str.ToString();
        }

    }
}
