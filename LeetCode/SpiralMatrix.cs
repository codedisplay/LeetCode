using System.Collections.Generic;

namespace LeetCode
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            IList<int> list = new List<int>();
            if (matrix.Length == 0) return list;

            int i = 0, j = 0;
            int minI = 0, maxI = matrix.GetLength(0) - 1, minJ = 0, maxJ = matrix.Length / matrix.GetLength(0) - 1;
            char direction = 'r';

            while (i >= minI && i <= maxI && j >= minJ && j <= maxJ)
            {
                list.Add(matrix[i, j]);

                switch (direction)
                {
                    case 'r':
                        if (j == maxJ)
                        {
                            minI = minI + 1;
                            direction = 'd';
                            i++;
                        }
                        else
                            j++;
                        break;
                    case 'd':
                        if (i == maxI)
                        {
                            maxJ = maxJ - 1;
                            direction = 'l';
                            j--;
                        }
                        else
                            i = i + 1;
                        break;
                    case 'l':
                        if (j == minJ)
                        {
                            maxI = maxI - 1;
                            direction = 'u';
                            i--;
                        }
                        else
                            j = j - 1;
                        break;
                    case 'u':
                        if (i == minI)
                        {
                            minJ = minJ + 1;
                            direction = 'r';
                            j++;
                        }
                        else
                            i = i - 1;
                        break;
                    default:
                        break;
                }
            }

            return list;
        }
    }
}
