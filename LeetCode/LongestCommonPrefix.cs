using System;

namespace LeetCode
{
    public class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];

            int minLen = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
                minLen = Math.Min(strs[i].Length, minLen);

            for (int i = 0; i < minLen; i++)//char position
            {
                int currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)//iterate different strings
                {
                    if (strs[j][i] != currentChar)
                        return strs[0].Substring(0, i);
                }
            }

            return strs[0].Substring(0, minLen);
        }
    }
}
