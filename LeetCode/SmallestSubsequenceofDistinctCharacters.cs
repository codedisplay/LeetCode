using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SmallestSubsequenceofDistinctCharacters
    {
        public string SmallestSubsequence(string text)
        {
            Dictionary<char, int> found = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (found.ContainsKey(text[i]))
                {

                }
                else
                {

                }
            }

            return null;
        }
    }
}
