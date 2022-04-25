namespace LeetCode
{
    public class NumberofIslands
    {
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
                        total++;

                        VisitNeighbourLands(grid, i, j);
                    }
                }
            }

            return total;
        }

        public void VisitNeighbourLands(char[][] grid, int i, int j)
        {
            if (grid[i][j] != '1')
                return;

            grid[i][j] = '2';

            int m = grid.Length, n = grid[0].Length;

            if (i != 0)//up 
                VisitNeighbourLands(grid, i - 1, j);

            if (i != m - 1)//down 
                VisitNeighbourLands(grid, i + 1, j);

            if (j != 0)//left 
                VisitNeighbourLands(grid, i, j - 1);

            if (j != n - 1)//right 
                VisitNeighbourLands(grid, i, j + 1);
        }
    }
}
