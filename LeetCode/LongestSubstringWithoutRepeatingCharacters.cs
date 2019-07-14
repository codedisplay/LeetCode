using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int maxLength = 0, start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    maxLength = Math.Max(i - start, maxLength);

                    for (int j = start; j < dic[s[i]] ; j++)
                        dic.Remove(s[j]);

                    start = dic[s[i]] + 1;
                    dic[s[i]] = i;
                }
                else
                {
                    dic.Add(s[i], i);
                }
            }

            return Math.Max(s.Length - start, maxLength);
        }
    }
}
