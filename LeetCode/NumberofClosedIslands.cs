using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumberofClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            int total = 0;

            if (grid.Length == 0 || grid[0].Length == 0)
                return total;

            int m = grid.Length, n = grid[0].Length;

            for (int i = 0; i < m; i++)//rows
            {
                for (int j = 0; j < n; j++)//cols
                {
                    if (grid[i][j] == 0)
                    {
                        grid[i][0] = 0;// for row setting 0
                        grid[0][j] = 0;// for col
                    }
                }
            }

            return total;
        }
    }
}
