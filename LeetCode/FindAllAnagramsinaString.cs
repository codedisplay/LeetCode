using System.Collections.Generic;

namespace LeetCode
{
    public class FindAllAnagramsinaString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> values = new List<int>();
            int count = 0, pLength = p.Length;
            if (s.Length < pLength)
                return values;

            int[] lookup = new int[26], current = new int[26];//a - z lowercase

            for (int i = 0; i < pLength; i++)
                lookup[p[i] - 'a']++;

            for (int i = 0; i < pLength; i++)
            {
                int val = s[i] - 'a';

                if (lookup[val] > 0)
                {
                    current[val]++;

                    if (current[val] <= lookup[val])
                        count++;
                }
            }

            if (count == pLength)
                values.Add(0);

            for (int i = 0; i < s.Length - pLength; i++)
            {
                int old = s[i] - 'a', latest = s[i + pLength] - 'a';

                if (lookup[old] > 0)
                {
                    current[old]--;

                    if (current[old] < lookup[old])
                        count--;
                }

                if (lookup[latest] > 0)
                {
                    current[latest]++;
                    if (current[latest] <= lookup[latest])
                        count++;
                }

                if (count == pLength)
                    values.Add(i + 1);
            }

            return values;
        }
    }
}
