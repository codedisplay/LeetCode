using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Longest_Palindromic_Substring
    {

        //public static string LongestPalindrome(string s)
        //{
        //    if (s.Length == 0 || (s.Length == 2 && s[0] == s[1])) return s;

        //    string str = s.Substring(0, 1);

        //    for (int i = 0; i < s.Length - 2; i++)
        //    {
        //        for (int j = 1; j < 3; j++)
        //        {
        //            if (s[i] == s[i + j])
        //            {
        //                var current = ExtendPalindrome(s, i, i + j);

        //                if (current.Length > str.Length)
        //                    str = current;
        //            }
        //        }
        //    }

        //    if (str.Length == 1 && s.Length > 2 && s[s.Length - 2] == s[s.Length - 1]) return s.Substring(s.Length - 2, 2);

        //    return str;
        //}

        //private static string ExtendPalindrome(string s, int startIndex, int endIndex)
        //{
        //    while (true)
        //    {
        //        if (startIndex != 0 && endIndex != s.Length - 1 && s[startIndex - 1] == s[endIndex + 1])
        //        {
        //            startIndex--;
        //            endIndex++;
        //        }
        //        else
        //            return s.Substring(startIndex, endIndex - startIndex + 1);
        //    }
        //}

        public string LongestPalindrome(string s)
        {
            string maxPalindrome = string.Empty;
            int currentLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //odd
                currentLength = GetLongestPalindromeLength(s, i, i);
                if (currentLength > maxPalindrome.Length)
                    maxPalindrome = s.Substring(i - (currentLength / 2), currentLength);

                //even
                currentLength = GetLongestPalindromeLength(s, i, i + 1);
                if (currentLength > maxPalindrome.Length)
                    maxPalindrome = s.Substring(i - ((currentLength / 2) - 1), currentLength);
            }

            return maxPalindrome;
        }

        private int GetLongestPalindromeLength(string s, int start, int end)
        {
            int len =  0;

            while (start <= end && start >= 0 && end < s.Length && s[start] == s[end])
            {
                len = end - start + 1;// len + 2;
                start--;
                end++;
            }

            return len;
        }
    }
}
