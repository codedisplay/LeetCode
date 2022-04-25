using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Duplicate_Zeros
    {
        //[1,0,2,3,0,4,5,0] -> [1,0,0,2,3,0,0,4]
        //Inplace memory
        public void DuplicateZeros(int[] arr)
        {
            int count = 0;
            int len = arr.Length - 1;
            int i;
            int endIndex = len;

            for (i = 0; i <= len; i++)
            {
                count++;

                if (arr[i] == 0)
                {
                    count++;

                    if (count > arr.Length)
                    {
                        arr[len] = 0;
                        i--;
                        endIndex = len - 1;
                        break;
                    }
                }

                if (count == arr.Length)
                    break;
            }

            while (i >= 0 && endIndex != i)
            {
                arr[endIndex] = arr[i];
                endIndex--;

                if (arr[i] == 0)
                {
                    arr[endIndex] = 0;
                    endIndex--;
                }

                i--;
            }
        }
    }
}
