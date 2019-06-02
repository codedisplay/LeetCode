namespace LeetCode
{
    public class Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;

            int[][] grid = new int[n][];
            for (int i = 0; i < grid.Length; i++)
                grid[i] = new int[m];
            grid[0][0] = 1;

            for (int i = 0; i < grid.Length; i++)
            {
                int col = 0;

                while (col < grid[0].Length)
                {
                    var currentSum = grid[i][col];
                    if (i > 0)//top
                        currentSum += grid[i - 1][col];
                    if (col > 0)//left
                        currentSum += grid[i][col-1];

                    grid[i][col] = currentSum;
                    col++;
                }
            }

            return grid[n-1][m-1];
        }
    }
}
