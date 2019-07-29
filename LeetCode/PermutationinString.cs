using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PermutationinString
    {
        //TODO
        public bool CheckInclusion(string s1, string s2)
        {
            int[] lookup = new int[26];

            for (int i = 0; i < s1.Length; i++)
                lookup[s1[i] - 'a']++;

            for (int i = 0; i < s2.Length; i++)
            {
                var current = s2[i] - 'a';

                if (lookup[current] != 0)
                    lookup[current]--;
            }

            for (int i = 0; i < lookup.Length; i++)
            {
                if (lookup[i] > 0)
                    return false;
            }

            return true;
        }
    }
}
