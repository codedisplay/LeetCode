namespace LeetCode
{
    public class NumberofIslands
    {
        // TODO: DFS or BFS with queues
        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
                return 0;

            int m = grid.Length, n = grid[0].Length, total = 0;

            for (int i = 0; i < m; i++)//rows
            {
                for (int j = 0; j < n; j++)//cols
                {
                    if (grid[i][j] == '1')
                    {
                        grid[i][j] = '2';

                        if (!(i > 0 && grid[i - 1][j] == '2') && !(j > 0 && grid[i][j - 1] == '2'))
                        {
                            total++;
                        }
                    }
                }
            }

            return total;
        }
    }
}
