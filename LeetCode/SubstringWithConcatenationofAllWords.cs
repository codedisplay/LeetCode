using System.Collections.Generic;

namespace LeetCode
{
    public class SubstringWithConcatenationofAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> list = new List<int>();
            int currentStartIndex = 0;

            int i = 0;
            while (i < s.Length)
            {
                currentStartIndex = i;

                List<int> unprocessedProcessedWordsIndex = new List<int>();

                for (int j1 = 0; j1 < words.Length; j1++)
                {
                    unprocessedProcessedWordsIndex.Add(j1);

                    int j = 0;
                    while (j < unprocessedProcessedWordsIndex.Count)
                    {
                        bool isCurrentWordExists = true;
                        string currentWord = words[unprocessedProcessedWordsIndex[j]];

                        for (int k = 0; k < currentWord.Length; k++)
                        {
                            if (i < s.Length && currentWord[k] == s[i])
                                i++;
                            else
                            {
                                isCurrentWordExists = false;
                                break;
                            }
                        }

                        if (isCurrentWordExists)
                        {
                            unprocessedProcessedWordsIndex.Remove(unprocessedProcessedWordsIndex[j]);

                            if (unprocessedProcessedWordsIndex.Count != 0)
                                j = 0;
                            else
                                break;
                        }
                        else
                            j++;
                    }
                }

                if (unprocessedProcessedWordsIndex.Count == 0)
                    list.Add(currentStartIndex);

                i = currentStartIndex + 1;
            }

            return list;
        }
    }
}
