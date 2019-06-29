using System;

namespace LeetCode
{
    public class MaximumLengthofPairChain
    {
        public int FindLongestChain(int[][] pairs)
        {
            if (pairs.Length == 0 || pairs[0].Length == 0)
                return 0;

            Array.Sort(pairs, (p1, p2) => { return p1[0] - p2[0]; });//asc

            int m = pairs.Length, n = pairs[0].Length;
            int prevVal = pairs[0][1];
            int seqCount = 1;

            for (int i = 1; i < m; i++)
            {
                if (pairs[i][0] <= prevVal)
                {
                    prevVal = Math.Min(pairs[i][1], prevVal);
                    continue;
                }

                seqCount++;
                prevVal = pairs[i][1];
            }

            return seqCount;
        }
    }
}
