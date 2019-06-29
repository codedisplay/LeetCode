using System;

namespace LeetCode
{
    public class LongestPalindromicSubsequence
    {
        public int LongestPalindromeSubseq(string s)
        {
            int[][] dp = new int[s.Length + 1][];

            for (int i = 0; i <= s.Length; i++)
            {
                dp[i] = new int[s.Length + 1];
                dp[0][i] = 0;
                dp[i][0] = 0;
            }

            int strLen = s.Length;
            for (int i = 1; i <= strLen; i++)
            {
                for (int j = 1; j <= strLen; j++)
                {
                    if (s[strLen - i] == s[j - 1])
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    else
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            }

            return dp[s.Length][s.Length];
        }
    }
}
