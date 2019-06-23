using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0)
                return 0;

            // Using O(n) memory // other way is to set the values in-place and return triangle[0][0]
            int[] arr = new int[triangle.Count];

            for (int j = 0; j < triangle.Count; j++)
                arr[j] = triangle[triangle.Count - 1][j];

            int currentLevel = triangle.Count - 2;

            while (currentLevel >= 0)
            {
                for (int i = 0; i <= currentLevel; i++)
                {
                    arr[i] = triangle[currentLevel][i] + Math.Min(arr[i], arr[i + 1]);
                }

                currentLevel--;
            }

            return arr[0];
        }

        // for next row back adjacent
        //public int MinimumTotal(IList<IList<int>> triangle)
        //{
        //    if (triangle.Count == 0)
        //        return 0;

        //    // Using O(n) memory // other way is to set the values in-place and return triangle[0][0]
        //    int[] arr = new int[triangle.Count];

        //    for (int j = 0; j < triangle.Count; j++)
        //        arr[j] = triangle[triangle.Count - 1][j];

        //    int currentLevel = triangle.Count - 2;
        //    // creating 2 variables instead of creating new temp int[] arr 
        //    int leftDown = 0, down = 0;

        //    while (currentLevel >= 0)
        //    {
        //        down = int.MaxValue;

        //        for (int i = 0; i <= currentLevel; i++)
        //        {
        //            leftDown = down;
        //            down = arr[i];

        //            arr[i] = triangle[currentLevel][i] + Math.Min(Math.Min(leftDown, down), arr[i + 1]);//arr[i + 1] -> rightDown
        //        }

        //        currentLevel--;
        //    }

        //    return arr[0];
        //}
    }
}
