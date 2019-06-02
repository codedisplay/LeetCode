using System.Diagnostics;

namespace LeetCode
{
    public class RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            int col, minutes = 0;
            bool isAnyRottenNow = true, isFreshFound = true;

            while (isFreshFound)
            {
                isFreshFound = false;
                isAnyRottenNow = false;
                minutes++;

                for (int i = 0; i < grid.Length; i++)
                {
                    col = 0;

                    while (col < grid[0].Length)
                    {
                        if (grid[i][col] == 1)
                        {
                            if (i > 0 && grid[i - 1][col] == 2 + minutes - 1//top
                                || col != grid[0].Length - 1 && grid[i][col + 1] == 2 + minutes - 1//right
                                || i != grid.Length - 1 && grid[i + 1][col] == 2 + minutes - 1//down
                                || col > 0 && grid[i][col - 1] == 2 + minutes - 1)//left
                            {
                                grid[i][col] = 2 + minutes;
                                isAnyRottenNow = true;
                            }
                            else
                                isFreshFound = true;
                        }

                        col++;
                    }
                }

                if (isFreshFound && !isAnyRottenNow)
                    return -1;
                else if (minutes == 1 && !isFreshFound && !isAnyRottenNow)
                    return 0;
            }

            return minutes;
        }
    }
}
