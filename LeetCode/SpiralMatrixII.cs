using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for (int j = 0; j < n; j++)
                matrix[j] = new int[n];

            int level = 0, currentMaxIndex = n - 1, currentNumber = 0, lastNumber = 0;

            while (level <= currentMaxIndex)
            {
                currentNumber = lastNumber;
                n = currentMaxIndex - level + 1;

                if (level == currentMaxIndex)
                    matrix[level][level] = currentNumber + 1;
                else
                    for (int i = 0; (i + level) < currentMaxIndex; i++)
                    {
                        currentNumber++;

                        matrix[level][level + i] = currentNumber;//left-top
                        matrix[level + i][currentMaxIndex] = matrix[level][level + i] + (n - 1);//right-top
                        matrix[currentMaxIndex][currentMaxIndex - i] = matrix[level + i][currentMaxIndex] + (n - 1);//right-down
                        matrix[currentMaxIndex - i][level] = matrix[currentMaxIndex][currentMaxIndex - i] + (n - 1);//left-down

                        lastNumber = matrix[currentMaxIndex - i][level];
                    }

                level++;
                currentMaxIndex--;
            }

            return matrix;
        }
    }
}
