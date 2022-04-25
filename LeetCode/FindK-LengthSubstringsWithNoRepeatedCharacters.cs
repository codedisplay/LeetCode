using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindK_LengthSubstringsWithNoRepeatedCharacters
    {
        //All characters of S are lowercase English letters.
        //1 <= K <= 10^4
        public int NumKLenSubstrNoRepeats(string S, int K)
        {
            if (S.Length <= K || S.Length == 0)
                return 0;

            int noOfSubStr = 0;
            int totalCharsFound = 0;
            int[] lookup = new int[26];//a - z lowercase
            int i;

            for (i = 0; i < K; i++)
            {
                if (lookup[S[i] - 'a'] == 0)
                    totalCharsFound++;

                lookup[S[i] - 'a']++;
            }

            if (totalCharsFound == K)
                noOfSubStr++;

            i = 0;
            while (i + K < S.Length)
            {
                if (lookup[S[i] - 'a'] == 1)
                    totalCharsFound--;
                lookup[S[i] - 'a']--;

                if (lookup[S[i + K] - 'a'] == 0)
                    totalCharsFound++;
                lookup[S[i + K] - 'a']++;

                if (totalCharsFound == K)
                    noOfSubStr++;

                i++;
            }

            return noOfSubStr;
        }
    }
}
