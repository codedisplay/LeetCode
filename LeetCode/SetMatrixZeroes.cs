namespace LeetCode
{
    public class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return;

            int m = matrix.Length, n = matrix[0].Length;
            bool headerRowSetZero = false, headerColSetZero = false;

            // Special handling for header rows and cols
            if (matrix[0][0] == 0)
            {
                headerColSetZero = true;
                headerRowSetZero = true;
            }
            else
            {
                for (int i = 1; i < n; i++)
                    if (matrix[0][i] == 0)
                    {
                        headerRowSetZero = true;
                        break;
                    }

                for (int i = 1; i < m; i++)
                    if (matrix[i][0] == 0)
                    {
                        headerColSetZero = true;
                        break;
                    }
            }

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;// set row header to 0
                        matrix[0][j] = 0;// set col header to 0
                    }

            for (int i = 1; i < m; i++) // set all row vals to 0
            {
                if (matrix[i][0] != 0)
                    continue;

                for (int j = 1; j < n; j++)
                    matrix[i][j] = 0;
            }

            for (int j = 1; j < n; j++)
            {
                if (matrix[0][j] != 0)
                    continue;

                for (int k = 1; k < m; k++)
                    matrix[k][j] = 0;
            }

            if (headerRowSetZero)
                for (int j = 0; j < n; j++)
                    matrix[0][j] = 0;

            if (headerColSetZero)
                for (int j = 0; j < m; j++)
                    matrix[j][0] = 0;
        }
    }
}
