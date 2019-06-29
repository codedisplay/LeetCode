using System;

namespace LeetCode
{
    public class LargestPlusSign
    {
        public struct HalfDetails
        {
            public int one { get; set; }//top && down
            public int two { get; set; }//left && right
        }

        public int OrderOfLargestPlusSign(int N, int[][] mines)
        {
            int currentMax = 0;
            HalfDetails[][] dp = new HalfDetails[N][];

            for (int i = 0; i < N; i++)
                dp[i] = new HalfDetails[N];

            foreach (int[] mine in mines)
                if (mine.Length == 2)
                {
                    dp[mine[0]][mine[1]].one = -1;
                    dp[mine[0]][mine[1]].two = -1;
                }

            for (int i = 0; i < N; i++)//compute all the values from top and left
                for (int j = 0; j < N; j++)
                {
                    if (dp[i][j].one != -1 && i != 0 && j != 0 && i != N - 1 && j != N - 1)
                    {
                        dp[i][j].one = dp[i - 1][j].one == -1 ? 0 : dp[i - 1][j].one;
                        dp[i][j].two = dp[i][j - 1].two == -1 ? 0 : dp[i][j - 1].two;
                    }

                    dp[i][j].one++;
                    dp[i][j].two++;
                }

            for (int i = N - 1; i >= 0; i--)
                for (int j = N - 1; j >= 0; j--)
                {
                    if (dp[i][j].one > 0)//current box valid
                    {
                        var current = 1;
                        if (!(i == N - 1 || j == N - 1 || i == 0 || j == 0))
                        {
                            dp[i][j].one = Math.Min(dp[i + 1][j].one, dp[i - 1][j].one) + 1;//topDown
                            dp[i][j].two = Math.Min(dp[i][j - 1].two, dp[i][j + 1].two) + 1;//leftRight
                            current = Math.Max(Math.Min(dp[i][j].one, dp[i][j].two), 1);
                        }

                        currentMax = Math.Max(current, currentMax);
                    }
                }

            return currentMax;
        }
    }
}
