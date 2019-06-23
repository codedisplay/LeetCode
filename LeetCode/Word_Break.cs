using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Word_Break
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (s.Length == 0)
                return false;

            IList<string> computedValues = new List<string>();

            return WordBreakHelper(s, wordDict, wordDict.ToList(), computedValues);
        }

        public bool WordBreakHelper(string s, IList<string> wordDict, List<string> lookDict, IList<string> computedValues)
        {
            if (s.Length == 0)
                return true;

            if (computedValues.IndexOf(s) > -1)
                return true;

            for (int i = 1; i <= s.Length; i++)
            {
                string current = s.Substring(0, i);

                if (lookDict.Contains(current))
                {
                    if (WordBreakHelper(s.Substring(i), wordDict, wordDict.ToList(), computedValues))
                    {
                        computedValues.Add(current);
                        return true;
                    }
                    else
                        lookDict.Remove(s.Substring(0, i));
                }
            }

            return false;
        }
    }
}
