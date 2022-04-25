using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SplitaStringinBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            int balancedCount = 0;

            int lCounter = 0, rCounter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (c == 'L')
                {
                    lCounter++;
                }
                else if (c == 'R')
                {
                    rCounter++;
                }

                if (lCounter == rCounter)
                {
                    balancedCount++;
                    lCounter = 0;
                    rCounter = 0;
                }
            }


            return balancedCount;
        }
    }
}
