using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //public class LongestSubstringWithoutRepeatingCharacters
    //{
    //    public int LengthOfLongestSubstring(string s)
    //    {
    //        Dictionary<char, int> dic = new Dictionary<char, int>();
    //        int maxLength = 0, start = 0;

    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            if (dic.ContainsKey(s[i]))
    //            {
    //                maxLength = Math.Max(i - start, maxLength);

    //                for (int j = start; j < dic[s[i]] ; j++)
    //                    dic.Remove(s[j]);

    //                start = dic[s[i]] + 1;
    //                dic[s[i]] = i;
    //            }
    //            else
    //            {
    //                dic.Add(s[i], i);
    //            }
    //        }

    //        return Math.Max(s.Length - start, maxLength);
    //    }
    //}
    //"abcabcbb"
    //"bbbbb
    //"pwwkew"
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int currentLength = 0;
            int maxLength = 0;
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (dic.ContainsKey(c))
                {
                    int charExistingIndex = dic[c];
                    while (j < charExistingIndex)
                    {
                        var currentChar = s[j];
                        if (dic.ContainsKey(currentChar))
                            dic.Remove(currentChar);
                        j++;
                    }

                    j = dic[c] + 1;
                    dic[c] = i;
                    currentLength = i - j + 1;
                }
                else
                {
                    dic.Add(c, i);
                    currentLength++;
                }

                maxLength = Math.Max(currentLength, maxLength);
            }

            return maxLength;
        }
    }
}
