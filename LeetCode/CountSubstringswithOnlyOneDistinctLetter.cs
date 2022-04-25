using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CountSubstringswithOnlyOneDistinctLetter
    {
        public int CountLetters(string S)
        {
            int noOfSubstrings = 0;
            char prev = ' ';
            int start = 0;

            for (int i = 0; i < S.Length; i++)
            {
                char c = S[i];
                
                if (c != prev)
                {
                    noOfSubstrings += GetSubStrings(i - start);
                    prev = c;
                    start = i;
                }
            }

            return noOfSubstrings + GetSubStrings(S.Length - start);
        }

        public int GetSubStrings(int len)
        {
          return  len * (len + 1) / 2;
        }
    }
}
