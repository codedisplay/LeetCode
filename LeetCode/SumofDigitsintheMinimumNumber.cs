using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SumofDigitsintheMinimumNumber
    {
        // [34,23,1,24,75,33,54,8] -> 0
        // [99,77,33,66,55] -> 1
        public int SumOfDigits(int[] A)
        {
            int minNum = int.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                minNum = Math.Min(minNum,A[i]);
            }

            int sum = 0,current = minNum;
            while (current != 0)
            {
                sum += current % 10;
                current = current / 10;
            }

            return sum % 2 == 0 ? 1 : 0;
        }
    }
}
