using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Minimum_Path_Sum
    {
        public int MinPathSum(int[][] grid)
        {
            int i, col = 0;

            for (i = 0; i < grid.Length; i++)
            {
                col = 0;

                while (col < grid[0].Length)
                {
                    if (i > 0 && col > 0)
                        grid[i][col] += Math.Min(grid[i - 1][col], grid[i][col - 1]);//min of top and left cells
                    else if (col > 0)
                        grid[i][col] += grid[i][col - 1];
                    else if (i > 0)
                        grid[i][col] += grid[i - 1][col];

                    col++;
                }
            }

            return grid[i - 1][col - 1];
        }
    }
}
