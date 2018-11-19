using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ShortestDistanceToACharacter
    {
        public int[] ShortestToChar(string S, char C)
        {
            int[] arr = new int[S.Length];
            List<int> indexes = new List<int>();
            int i;

            for (i = 0; i < S.Length; i++)
                if (S[i] == C)
                    indexes.Add(i);

            for (int j = 0; j <= indexes.Count; j++)
            {
                if (j == 0)
                {
                    i = 0;
                    while (i < S.Length && i <= indexes[j])
                    {
                        arr[i] = indexes[j] - i;
                        i++;
                    }
                }
                else if (j == indexes.Count && i < S.Length)
                {
                    while (i < S.Length)
                    {
                        arr[i] = i - indexes[j - 1];
                        i++;
                    }
                }
                else
                {
                    while (i < S.Length && i <= indexes[j])
                    {
                        arr[i] = Math.Min(Math.Abs(indexes[j - 1] - i), Math.Abs(indexes[j] - i));
                        i++;
                    }
                }
            }

            return arr;
        }
    }
}
