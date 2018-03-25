using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Partition_Labels
    {
        public IList<int> PartitionLabels(string S)
        {
            List<int> values = new List<int>();

            Dictionary<char, int> charMaxIndexPairs = new Dictionary<char, int>();

            for (int i = 0; i < S.Length; i++)
                charMaxIndexPairs[S[i]] = i;

            for (int i = 0; i < S.Length; i++)
            {
                char currentChar = S[i];
                int currentCharMaxIndex = charMaxIndexPairs[currentChar];
                int currentMaxIndex = -1;

                while (currentMaxIndex != currentCharMaxIndex)
                {
                    int subStringStartIndex = i;

                    if (currentMaxIndex != -1)
                    {
                        //subStringStartIndex = currentCharMaxIndex;
                        currentCharMaxIndex = currentMaxIndex;
                    }
                    //else
                    //    subStringStartIndex = i;

                    // TODO: During second iteration again start index is the previous index, 
                    // fix that to be the new index

                    currentMaxIndex =
                        GetSubStringMaxIndex(
                            S.Substring(subStringStartIndex, currentCharMaxIndex - i),
                            i,
                            charMaxIndexPairs);
                }

                int length = currentMaxIndex - i + 1;

                values.Add(length);
                i = i + (length - 1);
            }

            return values;
        }

        private static int GetSubStringMaxIndex(string subString, int currentStartIndex, Dictionary<char, int> charMaxIndexPairs)
        {
            int maxIndex = currentStartIndex;

            for (int i = 0; i < subString.Length; i++)
            {
                int currentMaxIndex = charMaxIndexPairs[subString[i]];

                if (currentMaxIndex > maxIndex)
                    maxIndex = currentMaxIndex;
            }

            return maxIndex;
        }
    }
}
