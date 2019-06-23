using System;

namespace LeetCode
{
    public class EditDistance
    {
        public int MinDistance(string word1, string word2)
        {
            int[,] dp = new int[word2.Length + 1, word1.Length + 1];

            for (int i = 0; i < word1.Length + 1; i++)
                dp[0, i] = i;//  deletions   

            for (int j = 1; j < word2.Length + 1; j++)
                dp[j, 0] = j;//  additions   

            for (int j = 1; j < word2.Length + 1; j++)
            {
                for (int i = 1; i < word1.Length + 1; i++)
                {
                    if (word1[i - 1] != word2[j - 1])
                        dp[j, i] = 1 + Math.Min(dp[j - 1, i], dp[j, i - 1]);
                    else
                        dp[j, i] = dp[j - 1, i - 1];
                }
            }

            return dp[word2.Length, word1.Length];
        }
    }
}
