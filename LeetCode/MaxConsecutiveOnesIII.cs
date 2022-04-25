using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaxConsecutiveOnesIII
    {
        //A = [1,1,1,0,0,0,1,1,1,1,0], K = 2
        public int LongestOnes(int[] A, int K)
        {
            int max = 0, currMax = 0, usedKCount = 0;
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                    currMax++;
                else if (usedKCount < K)
                {
                    currMax++;
                    usedKCount++;
                    queue.Enqueue(i);
                }
                else if (K == 0)
                    currMax = 0;
                else//usedKCount == K && K != 0
                {
                    int removeZeroIndex = queue.Dequeue();
                    currMax = i - removeZeroIndex;
                    queue.Enqueue(i);
                }

                max = Math.Max(max, currMax);
            }

            return max;
        }
    }
}
