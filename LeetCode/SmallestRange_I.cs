using System;

namespace LeetCode
{
    public class SmallestRange_I
    {
        public int SmallestRangeI(int[] A, int K)
        {
            if (A.Length == 0) return 0;

            int min = A[0], max = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                    min = A[i];
                else if (A[i] > max)
                    max = A[i];
            }

            int diff = Math.Abs(max - min);

            return (diff - (2 * K) >= 0) ? diff - (2 * K) : 0;
        }
    }
}
