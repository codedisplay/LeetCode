using System.Collections.Generic;

namespace LeetCode
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> list = new List<string>();
            int filledCharsInCurrentStr, startWordIndexInCurrentStr = -1, currentWordIndex = -1;
            bool isLastWordReached = false;

            while (!isLastWordReached)
            {
                bool isLastEndWithSpace = false;

                filledCharsInCurrentStr = 0;
                startWordIndexInCurrentStr = currentWordIndex + 1;

                // Form each new formatted string
                while (currentWordIndex + 1 < words.Length &&
                    filledCharsInCurrentStr + (words[currentWordIndex + 1].Length) <= maxWidth)
                {
                    currentWordIndex++;
                    filledCharsInCurrentStr += words[currentWordIndex].Length;

                    if (filledCharsInCurrentStr < maxWidth)
                    {
                        filledCharsInCurrentStr++;//+1 is for spaces after words,if not last word in current string
                        isLastEndWithSpace = true;
                    }
                    else
                        isLastEndWithSpace = false;
                }

                if (isLastEndWithSpace)
                    filledCharsInCurrentStr--;

                int toAddSpaces, remainingSpaces = (maxWidth - filledCharsInCurrentStr);
                int extraSpaces, gapsBetweenChars = (currentWordIndex - startWordIndexInCurrentStr);

                // For the last line of text, it's left justified and no extra space is inserted between words
                isLastWordReached = (currentWordIndex >= words.Length - 1);

                if (gapsBetweenChars > 0 && !isLastWordReached)// may be last or only word
                {
                    toAddSpaces = remainingSpaces / gapsBetweenChars;
                    extraSpaces = remainingSpaces % gapsBetweenChars;//+(maxWidth - filledCharsInCurrentStr)

                }
                else
                    toAddSpaces = extraSpaces = 0;

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(maxWidth);

                for (int i = startWordIndexInCurrentStr; i <= currentWordIndex; i++)
                {
                    stringBuilder.Append(words[i]);

                    if (i != currentWordIndex)
                    {
                        stringBuilder.Append(' ', toAddSpaces + 1);// appends toAddSpaces times of spaces/ +1 is the default space after each word

                        if (extraSpaces > 0)
                        {
                            stringBuilder.Append(' ');
                            extraSpaces--;
                        }
                    }
                }

                list.Add(stringBuilder.Append(' ', maxWidth - stringBuilder.Length).ToString());//add condition to append only for isLastWordReached
            }

            return list;
        }


        //public IList<string> FullJustify(string[] words, int maxWidth)
        //{
        //    IList<string> list = new List<string>();

        //    if (words.Length == 0)
        //        return list;

        //    int currentWordIndex = 0;
        //    int filledCharsInCurrentString = 0;
        //    int wordsAddedToCurrentString = 0;
        //    char[] currentString = new char[maxWidth];

        //    int currentWordsStartIndex = 0;

        //    while (currentWordIndex < words.Length)
        //    {
        //        while (filledCharsInCurrentString <= maxWidth)
        //        {
        //            string currentWord = words[currentWordIndex];

        //            if (currentWord.Length + filledCharsInCurrentString <= maxWidth)
        //            {
        //                if (filledCharsInCurrentString != 0)// skip adding spaces before 1st word
        //                {
        //                    currentString[filledCharsInCurrentString] = ' ';
        //                    filledCharsInCurrentString++;
        //                }



        //                //currentWord.CopyTo(0, currentString, filledCharsInCurrentString, currentWord.Length);

        //                //currentString.SetValue(currentWord,filledCharsInCurrentString);
        //                filledCharsInCurrentString += currentWord.Length;
        //                currentWordIndex++;
        //                wordsAddedToCurrentString++;
        //            }
        //            else
        //            {
        //                int remainingSpaces = maxWidth - filledCharsInCurrentString;
        //                int gapsBetweenChars = wordsAddedToCurrentString - 1;

        //                int toAddSpaces = remainingSpaces / gapsBetweenChars;
        //                int extraSpaces = remainingSpaces % gapsBetweenChars;

        //                for (int i = 0; i < currentString.Length; i++)
        //                {
        //                    if (currentString[i] == ' ')
        //                    {

        //                    }
        //                }
        //            }
        //        }

        //        list.Add(currentString.ToString());
        //        //currentString.Clear();
        //        filledCharsInCurrentString = 0;
        //        wordsAddedToCurrentString = 0;
        //    }

        //    return list;
        //}

        //public IList<string> FullJustify1(string[] words, int maxWidth)
        //{
        //    IList<string> list = new List<string>();

        //    if (words.Length == 0)
        //        return list;

        //    int currentWordIndex = 0;
        //    int wordsAddedToCurrentString = 0;
        //    char[] currentString = new char[maxWidth];
        //    int filledCharsInCurrentString = 0;

        //    while (currentWordIndex < words.Length)
        //    {
        //        while (filledCharsInCurrentString <= maxWidth)
        //        {
        //            string currentWord = words[currentWordIndex];

        //            if (currentWord.Length + filledCharsInCurrentString <= maxWidth)
        //            {
        //                if (filledCharsInCurrentString != 0)// skip adding spaces before 1st word
        //                {
        //                    currentString[filledCharsInCurrentString] = ' ';
        //                    filledCharsInCurrentString++;
        //                }

        //                currentWord.CopyTo(0, currentString, filledCharsInCurrentString, currentWord.Length);

        //                //currentString.SetValue(currentWord,filledCharsInCurrentString);
        //                filledCharsInCurrentString += currentWord.Length;
        //                currentWordIndex++;
        //                wordsAddedToCurrentString++;
        //            }
        //            else
        //            {
        //                int remainingSpaces = maxWidth - filledCharsInCurrentString;
        //                int gapsBetweenChars = wordsAddedToCurrentString - 1;

        //                int toAddSpaces = remainingSpaces / gapsBetweenChars;
        //                int extraSpaces = remainingSpaces % gapsBetweenChars;

        //                for (int i = 0; i < currentString.Length; i++)
        //                {
        //                    if (currentString[i] == ' ')
        //                    {

        //                    }
        //                }
        //            }
        //        }

        //        list.Add(currentString.ToString());
        //        //currentString.Clear();
        //        filledCharsInCurrentString = 0;
        //        wordsAddedToCurrentString = 0;
        //    }

        //    return list;
        //}


        //public IList<string> FullJustify(string[] words, int maxWidth)
        //{
        //    IList<string> list = new List<string>();

        //    if (words.Length == 0)
        //        return list;

        //    int currentWordIndex = 0;
        //    int wordsAddedToCurrentString = 0;
        //    System.Text.StringBuilder currentString = new System.Text.StringBuilder(maxWidth);// TODO: use char[] ?

        //    while (currentWordIndex < words.Length)
        //    {
        //        while (currentString.Length <= maxWidth)
        //        {
        //            string currentWord = words[currentWordIndex];

        //            if (currentWord.Length + currentString.Length <= maxWidth)
        //            {
        //                if (currentString.Length  != 0)// skip adding spaces before 1st word
        //                    currentString.Append(' ');

        //                currentString.Append(currentWord);
        //                currentWordIndex++;
        //                wordsAddedToCurrentString++;


        //            }
        //            else
        //            {
        //                int remainingSpaces = maxWidth - currentString.Length;
        //                int gapsBetweenChars = wordsAddedToCurrentString - 1;

        //                while (remainingSpaces == 0)
        //                {

        //                }
        //            }
        //        }

        //        list.Add(currentString.ToString());
        //        currentString.Clear();
        //        wordsAddedToCurrentString = 0;
        //    }

        //    return list;
        //}

    }
}
