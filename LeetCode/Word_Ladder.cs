using System.Collections.Generic;

namespace LeetCode
{
    public class Word_Ladder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            return GetCount(beginWord, endWord, 1, wordList);
        }

        private int GetCount(string beginWord, string endWord, int count, IList<string> wordList)
        {
            int currentMinCount = -1;

            if (beginWord != endWord)
                for (int i = 0; i < wordList.Count; i++)
                {
                    int current = 0;
                    var nextStr = GetNextStringByOneCharChange(beginWord, wordList, i, ref current);

                    if (nextStr != null)
                    {
                        var newList = getNewWordList(wordList, nextStr);
                        var response = GetCount(nextStr, endWord, current + count, newList);

                        if (response > 0 && (currentMinCount == -1 || currentMinCount > response))
                            currentMinCount = response;
                    }
                }
            else
                return count;

            return currentMinCount == -1 ? 0 : currentMinCount;
        }

        private IList<string> getNewWordList(IList<string> wordList, string removeString)
        {
            var newWordList = new List<string>();

            foreach (var word in wordList)
                newWordList.Add(word);
            newWordList.Remove(removeString);

            return newWordList;
        }

        private string GetNextStringByOneCharChange(string currentString, IList<string> wordList, int strtIndex, ref int count)
        {
            if (strtIndex == -1) strtIndex = 0;

            for (int index = strtIndex; index < wordList.Count; index++)
            {
                int charsDifferent = 0;

                for (int i = 0; i < wordList[index].Length; i++)
                {
                    if (wordList[index][i] != currentString[i])
                    {
                        charsDifferent++;

                        if (charsDifferent > 1)
                            break;
                    }
                }

                if (charsDifferent == 1)
                {
                    count++;
                    return wordList[index];
                }
            }

            count = 0;
            return null;
        }

        //private int GetCount1(string beginWord, string endWord, int count, ref IList<string> wordList)
        //{
        //    string str = beginWord;

        //    while (!string.Equals(str, endWord))
        //    {
        //        str = GetNextStringByOneCharChange(str, wordList, wordList.IndexOf(str), ref count);
        //    }

        //    count++;
        //    return count;
        //}

        //private string GetNextStringByOneCharChange(string currentString, IList<string> wordList, int strtIndex, ref int count)
        //{
        //    if (strtIndex == -1) strtIndex = 0;

        //    for (int index = strtIndex; strtIndex < wordList.Count; index++)
        //    {
        //        int charsDifferent = 0;

        //        for (int i = 0; i < wordList[index].Length; i++)
        //        {
        //            if (wordList[index][i] != currentString[i])
        //            {
        //                charsDifferent++;
        //                break;
        //            }
        //        }

        //        if (charsDifferent == 1)
        //        {
        //            count++;
        //            return wordList[index];
        //        }
        //    }

        //    count = 0;
        //    return null;
        //}
    }
}
