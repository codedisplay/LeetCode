using System;

namespace LeetCode
{
    public class Add_Strings
    {
        public string AddStrings(string num1, string num2)
        {
            char[] arr = new char[Math.Max(num1.Length, num2.Length) + 1];
            int index1 = num1.Length - 1, index2 = num2.Length - 1, current = 0, index = arr.Length-1;

            while (index1 >= 0 || index2 >= 0 || current > 0)
            {
                if (index1 >= 0)
                {
                    current += num1[index1] - '0';
                    index1--;
                }
                if (index2 >= 0)
                {
                    current += num2[index2] - '0';
                    index2--;
                }
                    
                arr[index] = char.Parse((current%10).ToString());
                current = current / 10;
                index--;
            }

            return (index == 0) ? new string(arr).Substring(1, arr.Length - 1) : new string(arr);
        }
    }
}
