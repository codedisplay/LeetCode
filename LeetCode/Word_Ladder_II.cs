using System.Collections.Generic;

namespace LeetCode
{
    public class Word_Ladder_II
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            IList<IList<string>> ladders = new List<IList<string>>();

            var x = GetValues(beginWord, endWord, wordList);

            return ladders;
        }

        private IList<string> GetValues(string beginWord, string endWord, IList<string> wordList)
        {
            IList<string> currentPath = new List<string> { beginWord };
            IList<string> newWordList = wordList;

            string nextTransformString = beginWord;

            while (nextTransformString != null && newWordList.Count > 0)
            {
                nextTransformString = GetNextStringByOneCharChange(nextTransformString, newWordList);

                if (nextTransformString == null)
                    break;

                currentPath.Add(nextTransformString);

                if (endWord.Equals(nextTransformString))
                    return currentPath;
                else
                    newWordList.Remove(nextTransformString);
            }

            return new List<string> { };
        }

        private string GetNextStringByOneCharChange(string currentString, IList<string> wordList)
        {
            foreach (string word in wordList)
            {
                int charsDifferent = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != currentString[i])
                    {
                        charsDifferent++;

                        if (charsDifferent > 1)
                            break;
                    }
                }

                if (charsDifferent == 1)
                    return word;
            }

            return null;
        }





        //private void GetValues(string beginWord, string endWord, IList<string> wordList)
        //{
        //    string nextTransformString = beginWord;
        //    IList<string> newWordList = wordList;

        //    while (nextTransformString != null && newWordList.Count > 0)
        //    {
        //        nextTransformString = GetTransformableString(nextTransformString, endWord, wordList);

        //        newWordList.Remove(nextTransformString);
        //    }
        //}

        //private string GetTransformableString(string fromString, string toString, IList<string> wordList)
        //{
        //    foreach (char c in toString)
        //    {
        //        for (int i = 0; i < fromString.Length; i++)
        //        {
        //            string currentString = ReplaceCharInStringByIndex(fromString, i, c);

        //            if (wordList.Contains(currentString))
        //                return currentString;
        //        }
        //    }

        //    return null;
        //}

        //private string ReplaceCharInStringByIndex(string currentString, int index, char replaceChar)
        //{
        //    if (index >= currentString.Length)
        //        return currentString;

        //    char[] charArr = currentString.ToCharArray();
        //    charArr[index] = replaceChar;

        //    return new string(charArr);
        //}
    }
}
