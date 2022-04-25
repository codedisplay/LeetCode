using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstringwithAtMostTwoDistinctCharacters
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            if (s.Length < 3)
                return s.Length;

            char char1 = s[0], char2 = ' ';
            int i = 0, longestSubStr = 2, start = i, end1 = i, end2 = -1;

            for (; i < s.Length; i++)
            {
                if (s[i] != char1)
                {
                    char2 = s[i];
                    end2 = i;
                    i++;
                    break;
                }
                else
                    end1 = i;
            }
            longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

            while (i < s.Length)
            {
                if (s[i] == char1)
                    end1 = i;
                else if (s[i] == char2)
                    end2 = i;
                else
                {
                    longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

                    if ((s[start] == char1 && end1 == i - 1) || (s[start] == char2 && end2 != i - 1))
                    {
                        start = end2 + 1;

                        char2 = s[i];
                        end2 = i;
                    }
                    else
                    {
                        start = end1 + 1;

                        char1 = s[i];
                        end1 = i;
                    }
                }

                i++;
            }

            return Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);
        }
        //Refactored method 
        //public int LengthOfLongestSubstringTwoDistinct(string s)
        //{
        //    if (s.Length < 3)
        //        return s.Length;

        //    char char1 = s[0], char2 = ' ';
        //    int i = 0, longestSubStr = 2, start = i, end1 = i, end2 = -1;

        //    for (; i < s.Length; i++)
        //    {
        //        if (s[i] != char1)
        //        {
        //            char2 = s[i];
        //            end2 = i;
        //            i++;
        //            break;
        //        }
        //        else
        //            end1 = i;
        //    }
        //    longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

        //    while (i < s.Length)
        //    {
        //        if (s[i] == char1)
        //            end1 = i;
        //        else if (s[i] == char2)
        //            end2 = i;
        //        else
        //        {
        //            longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

        //            if ((s[start] == char1 && end1 == i - 1) || (s[start] == char2 && end2 != i - 1))
        //            {
        //                start = end2 + 1;

        //                char2 = s[i];
        //                end2 = i;
        //            }
        //            else
        //            {
        //                start = end1 + 1;

        //                char1 = s[i];
        //                end1 = i;
        //            }
        //        }

        //        i++;
        //    }

        //    return Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);
        //}
        //working-understandable method
        //public int LengthOfLongestSubstringTwoDistinct(string s)
        //{
        //    if (s.Length < 3)
        //        return s.Length;

        //    char char1 = s[0], char2 = ' ';
        //    int i = 0, longestSubStr = 2, start = i, end1 = i, end2 = -1;

        //    for (; i < s.Length; i++)
        //    {
        //        if (s[i] != char1)
        //        {
        //            char2 = s[i];
        //            end2 = i;
        //            i++;
        //            break;
        //        }
        //        else
        //            end1 = i;
        //    }

        //    longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

        //    while (i < s.Length)
        //    {
        //        if (s[i] == char1)
        //            end1 = i;
        //        else if (s[i] == char2)
        //            end2 = i;
        //        else
        //        {
        //            longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

        //            if (s[start] == char1)
        //            {
        //                if (end1 == i - 1)
        //                {
        //                    start = end2 + 1;

        //                    char2 = s[i];
        //                    end2 = i;
        //                }
        //                else
        //                {
        //                    start = end1 + 1;

        //                    char1 = s[i];
        //                    end1 = i;
        //                }

        //            }
        //            else
        //            {
        //                if (end2 == i - 1)
        //                {
        //                    start = end1 + 1;

        //                    char1 = s[i];
        //                    end1 = i;
        //                }
        //                else
        //                {
        //                    start = end2 + 1;

        //                    char2 = s[i];
        //                    end2 = i;
        //                }
        //            }
        //        }

        //        i++;
        //    }

        //    longestSubStr = Math.Max(longestSubStr, Math.Max(end1, end2) - start + 1);

        //    return longestSubStr;
        //}
    }
}
