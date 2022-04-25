using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Valid_Mountain_Array
    {
        //[] 
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3 || A[0] >= A[1])
                return false;

            int counter = 1;

            while (A[counter - 1] < A[counter])
            {
                counter++;
                 
                if (counter == A.Length)
                    return false;
            }

            if (A[counter - 1] == A[counter])
                return false;

            while (A[counter - 1] > A[counter])
            {
                counter++;

                if (counter == A.Length)
                    return true;
            }

            return counter == A.Length;
        }
    }
}
