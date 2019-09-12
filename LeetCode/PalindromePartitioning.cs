using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> values = new List<IList<string>>();

            for (int i = 1; i < s.Length; i++)
            {
                Partition(s, 0, i, values);
            }

            return values;
        }

        public bool Partition(string s, int start, int end, IList<IList<string>> values)
        {
            for (int i = start; i < s.Length; i++)
            {
                while (start <= end)//find first substring
                {
                    if (s[start] != s[end])
                        continue;

                    start++;
                    end--;
                }

                if (start < s.Length)
                {
                    for (int j = start + 1; j < s.Length; j++)
                    {
                        Partition(s, start, j, values);
                    }
                }

            }

            return false;
        }
    }
}
