using System;

namespace LeetCode
{
    public class Maximal_Square
    {
        public int MaximalSquare(char[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return 0;

            int m = matrix.Length, n = matrix[0].Length, currentMax = 0;

            for (int i = 0; i < m; i++)//rows
            {
                for (int j = 0; j < n; j++)//cols
                {
                    int current = matrix[i][j] - '0';

                    if (current == 1)
                    {
                        int newVal;

                        if (i == 0 || j == 0)
                            newVal = 1;
                        else
                        {
                            int top = matrix[i - 1][j] - '0';
                            int left = matrix[i][j - 1] - '0';
                            int diag = matrix[i - 1][j - 1] - '0';

                            if (top > 0 && left > 0 && diag > 0)
                            {
                                newVal = Math.Min(diag, Math.Min(left, top)) + 1;
                                matrix[i][j] = (char)(newVal + '0');
                            }
                            else
                                newVal = 1;
                        }

                        currentMax = Math.Max(newVal, currentMax);
                    }
                }
            }

            return currentMax * currentMax;
        }
    }
}
