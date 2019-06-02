using System;

namespace LeetCode
{
    public class RotateImage
    {
        //int leftTop = 0;//level,level+i
        //int rightTop = 0;//level+i,currentMaxIndex
        //int rightDown = 0;//currentMaxIndex,currentMaxIndex-i
        //int leftDown = 0;//currentMaxIndex-i,level
        public void Rotate(int[][] matrix)
        {
            int level = 0, n = matrix.Length;
            int currentMaxIndex = n - 1;

            while (level < currentMaxIndex)
            {
                for (int i = 0; (i + level) < currentMaxIndex; i++)
                {
                    int temp = matrix[level + i][currentMaxIndex];
                    matrix[level + i][currentMaxIndex] = matrix[level][level + i];//right-top

                    int temp1 = matrix[currentMaxIndex][currentMaxIndex - i];
                    matrix[currentMaxIndex][currentMaxIndex - i] = temp;//right-down

                    temp = matrix[currentMaxIndex - i][level];
                    matrix[currentMaxIndex - i][level] = temp1;//left-down

                    matrix[level][level + i] = temp;//left-top
                }

                level++;
                currentMaxIndex--;
            }
        }
    }
}

