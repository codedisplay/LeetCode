namespace LeetCode
{
    public class Unique_Paths_II
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0 || obstacleGrid[0][0] == 1)
                return 0;

            obstacleGrid[0][0] = 1;
            int i, col = 0;

            for (i = 0; i < obstacleGrid.Length; i++)
            {
                col = i == 0 ? 1 : 0;

                while (col < obstacleGrid[0].Length)
                {
                    var currentSum = 0;

                    if (obstacleGrid[i][col] != 1)
                    {
                        if (i > 0)//top
                            currentSum += obstacleGrid[i - 1][col];
                        if (col > 0)//left
                            currentSum += obstacleGrid[i][col - 1];
                    }

                    obstacleGrid[i][col] = currentSum;
                    col++;
                }
            }

            return obstacleGrid[i - 1][col - 1];
        }
    }
}
