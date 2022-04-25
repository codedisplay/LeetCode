using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReplaceElementswithGreatestElementonRightSide
    {
        //[17,18,5,4,6,1] -> [18,6,6,6,1,-1]
        public int[] ReplaceElements(int[] arr)
        {
            int max = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = max;
                max = Math.Max(temp, max);

            }

            return arr;
        }
    }
}
