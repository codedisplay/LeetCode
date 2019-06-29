using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class OnesandZeroes
    {
        // TLE
        public int FindMaxForm(string[] strs, int m, int n)//m 0s and n 1s
        {
            List<int> ones = new List<int>();//Ones in each str

            for (int i = 0; i < strs.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < strs[i].Length; j++)
                    if (strs[i][j] == '1')
                        count++;

                ones.Add(count);
            }

            Dictionary<string, int> dp = new Dictionary<string, int>();
            int maxCount = 0;

            FindMaxForm(strs, m, n, ones, strs.Length - 1, 0, dp, ref maxCount);

            return maxCount;
        }

        public int FindMaxForm(string[] strs, int m, int n, List<int> ones, int currentEndIndex, int currentCount, Dictionary<string, int> dp, ref int maxCount)
        {
            if ((m == 0 && n == 0) || m < 0 || n < 0 || currentEndIndex < 0)
                return 0;

            string lookup = $"{currentEndIndex}-{m}-{n}";

            if (dp.ContainsKey(lookup))
                return dp[lookup];

            int currentOnes = ones[currentEndIndex], currentZeroes = strs[currentEndIndex].Length - currentOnes;

            //include current 
            int includeCount = (currentOnes <= n && currentZeroes <= m ? 1 : 0) + 
                FindMaxForm(strs, m - currentZeroes, n - currentOnes, ones, currentEndIndex - 1, currentCount + 1, dp, ref maxCount);

            //skip current
            int excludeCount = FindMaxForm(strs, m, n, ones, currentEndIndex - 1, currentCount, dp, ref maxCount);

            dp[lookup] = Math.Max(includeCount, excludeCount);
            maxCount = Math.Max(currentCount + dp[lookup], maxCount);

            return dp[lookup];
        }
    }
}
