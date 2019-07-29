using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DecodeWays
    {
        //TODO
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 1;
            if (s[0] == '0')
                return 0;

            int prevCount = 0, currentCount = 0;
            int count = 1;
            char prev = s[0], current;
            int doubleDigit;

            bool isValidNow = true;

            for (int i = 1; i < s.Length; i++)
            {
                current = s[i];

                if (prev > '2' || prev == '0')
                {
                    if (current == '0')
                        return 0;
                }
                else if (!((prev == '2' && current > '6') || current == '0'))
                    count++;

                prev = current;
            }

            return count;
        }
    }
}
