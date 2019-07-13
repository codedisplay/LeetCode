using System;

namespace LeetCode
{
    public class SquaresofaSortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            int[] squares = new int[A.Length];
            int left = 0, right = A.Length - 1, index = A.Length - 1;

            while (index >= 0)
            {
                var l = Math.Abs(A[left]);
                var r = Math.Abs(A[right]);

                if (l > r)
                {
                    squares[index] = l * l;
                    left++;
                }
                else
                {
                    squares[index] = r * r;
                    right--;
                }

                index--;
            }

            return squares;
        }
    }
}
