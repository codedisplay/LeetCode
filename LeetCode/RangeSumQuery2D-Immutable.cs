namespace LeetCode
{
    public class NumMatrix
    {
        int[][] dp;

        public NumMatrix(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return;

            int m = matrix.Length, n = matrix[0].Length;
            dp = new int[m + 1][];

            for (int i = 0; i <= m; i++)//rows
            {
                dp[i] = new int[n + 1];//initialize cols
            }

            for (int i = 0; i < m; i++)//rows
            {
                for (int j = 0; j < n; j++)//cols
                {
                    var val = dp[i][j + 1] + dp[i + 1][j] + matrix[i][j] - dp[i][j];
                    dp[i + 1][j + 1] = val;
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int totalFromStart = dp[row2 + 1][col2 + 1];
            int topTotal = dp[row1][col2 + 1];
            int leftTotal = dp[row2 + 1][col1] - dp[row1][col1];
            return totalFromStart - topTotal - leftTotal;
        }
    }
}
