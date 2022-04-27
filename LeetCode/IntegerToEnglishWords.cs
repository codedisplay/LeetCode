using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class IntegerToEnglishWords
    {
        //todo
        Dictionary<int, string> numStringPairs = new Dictionary<int, string>()
        {
            { 1,"One "},
            { 2,"Two "},
            { 3,"Three "},
            { 4,"Four "},
            { 5,"Five "},
            { 6,"Six "},
            { 7,"Seven "},
            { 8,"Eight "},
            { 9,"Nine "},
            { 10,"Ten "},
            { 11,"Eleven "},
            { 12,"Twelve "},
            { 13,"Thirteen "},
            { 14,"Fourteen "},
            { 15,"Fifteen "},
            { 16,"Sixteen "},
            { 17,"Seventeen "},
            { 18,"Eighteen "},
            { 19,"Nineteen "},
            { 20,"Twenty "},
            { 30,"Thirty "},
            { 40,"Forty "},
            { 50,"Fifty "},
            { 60,"Sixty "},
            { 70,"Seventy "},
            { 80,"Eighty "},
            { 90,"Ninety "},
            //{ 100,"Hundred "},
            //{ 1000,"Thousand "},
            //{ 1000000,"Million "},
            //{ 1000000000,"Billion "},
        };

        public string NumberToWords(int num)
        {
            StringBuilder finalString = new StringBuilder();

            if (numStringPairs.ContainsKey(num))
                return numStringPairs[num];

            if(num >= 1000000000)
            {
                int rem = num / 1000000000;
                finalString.Append(NumberToWords(rem));
                finalString.Append("Billion");
                num = num - 1000000000;
            }
            else if (num >= 1000000)
            {
                int rem = num / 1000000;
                finalString.Append(NumberToWords(rem));
                finalString.Append("Million");
                num = num - 1000000;
            }
            else if (num >= 1000)
            {
                int rem = num / 1000;
                finalString.Append(NumberToWords(rem));
                finalString.Append("Thousand");
                num = num - 1000;
            }
            else if (num >= 100)
            {
                int rem = num / 100;
                finalString.Append(NumberToWords(rem));
                finalString.Append("Hundred");
                num = num - 100;
            }

            foreach (var item in numStringPairs.Reverse())
            {
                if(num > item.Key)
                {
                    int rem = num / item.Key;
                    finalString.Append(NumberToWords(rem));
                    finalString.Append(item.Value);
                    num = num - item.Key;
                }
                else if (num == item.Key)
                {
                    finalString.Append(item.Value);
                }
            }

            return finalString.ToString();
        }

        //working
        //Dictionary<int, string> numStringPairs = new Dictionary<int, string>()
        //{
        //    { 1,"One "},
        //    { 2,"Two "},
        //    { 3,"Three "},
        //    { 4,"Four "},
        //    { 5,"Five "},
        //    { 6,"Six "},
        //    { 7,"Seven "},
        //    { 8,"Eight "},
        //    { 9,"Nine "},
        //    { 10,"Ten "},
        //    { 11,"Eleven "},
        //    { 12,"Twelve "},
        //    { 13,"Thirteen "},
        //    { 14,"Fourteen "},
        //    { 15,"Fifteen "},
        //    { 16,"Sixteen "},
        //    { 17,"Seventeen "},
        //    { 18,"Eighteen "},
        //    { 19,"Nineteen "},
        //    { 20,"Twenty "},
        //    { 30,"Thirty "},
        //    { 40,"Forty "},
        //    { 50,"Fifty "},
        //    { 60,"Sixty "},
        //    { 70,"Seventy "},
        //    { 80,"Eighty "},
        //    { 90,"Ninety "},
        //    { 100,"Hundred "}
        //};

        //private string GetUnitsString(double unit)
        //{
        //    if (unit >= 9) return "Billion ";
        //    else if (unit >= 6) return "Million ";
        //    else if (unit >= 3) return "Thousand ";
        //    else return "";
        //}

        //public string NumberToWords(int num)
        //{
        //    if (num == 0) return "Zero";

        //    StringBuilder finalString = new StringBuilder();

        //    double units = Math.Floor(Math.Log10(num));
        //    int currentPower = (int)Math.Pow(10, units - (units % 3));
        //    int currentThreeNums;

        //    while (units >= 0)
        //    {
        //        currentThreeNums = num / currentPower;
        //        num = num - (currentThreeNums * currentPower);

        //        if (currentThreeNums > 0)
        //            AppendString(finalString, currentThreeNums, units);

        //        units = units - 3;
        //        currentPower = currentPower / 1000;
        //    }

        //    return finalString.ToString().TrimEnd(' ');
        //}

        //private void AppendString(StringBuilder stringBuilder, int currentThreeNums, double units)
        //{
        //    int current = currentThreeNums;

        //    if (currentThreeNums >= 100)
        //    {
        //        current = currentThreeNums % 100;
        //        stringBuilder.Append(numStringPairs[currentThreeNums / 100]).Append("Hundred ");
        //    }

        //    int balanceValue = 0;

        //    while (current > 0)
        //    {
        //        if (numStringPairs.ContainsKey(current))
        //        {
        //            stringBuilder.Append(numStringPairs[current]);
        //            current = balanceValue;
        //            balanceValue = 0;
        //        }
        //        else
        //        {
        //            int nextVal = (current / 10) * 10;
        //            balanceValue = current - nextVal;
        //            current = nextVal;
        //        }
        //    }

        //    stringBuilder.Append(GetUnitsString(units));
        //}

        //// converting num to string implementation
        //public string NumberToWords1(int num)
        //{
        //    StringBuilder finalString = new StringBuilder();
        //    string numString = num.ToString();

        //    int units = numString.Length - 1;
        //    int currentPower = (int)Math.Pow(10, units - (units % 3));
        //    int currentThreeNums;

        //    while (units >= 0)
        //    {
        //        currentThreeNums = num / currentPower;
        //        num = num - (currentThreeNums * currentPower);

        //        // Append current nums to finalString 

        //        units = units - 3;
        //        currentPower = currentPower / 1000;
        //    }

        //    return finalString.ToString();
        //}
    }
}
