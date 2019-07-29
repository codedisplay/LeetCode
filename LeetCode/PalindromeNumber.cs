using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0)
                return true;
            if (x < 0 || x % 10 == 0)
                return false;

            List<char> list = new List<char>();

            while (x > 0)
            {
                list.Add((char)(x % 10));
                x = x / 10;
            }

            int start = 0, end = list.Count - 1;

            while (start < end)
            {
                if (list[start] != list[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }

}
