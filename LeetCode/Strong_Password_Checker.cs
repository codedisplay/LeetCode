using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Strong_Password_Checker
    {
        public int StrongPasswordChecker(String s)
        {
            int sLen = s.Length;
            if (sLen < 4)
            {
                return 6 - sLen;
            }

            int lnum = 1; // need lower
            int unum = 1; // need upper
            int dnum = 1; // need digit

            int rcount = 0;  // count need to replace repeated seq
            int ricount = 0; // count need to add in repeated seq
            int rdcount = 0; // count need to remove from repeated seq
            int sameseq = 0; // count of chars in repeated seq

            for (int i = 0; i < sLen; i++)
            {
                char ch = s[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    lnum = 0;
                }
                if (ch >= 'A' && ch <= 'Z')
                {
                    unum = 0;
                }
                if (ch >= '0' && ch <= '9')
                {
                    dnum = 0;
                }

                // check repeated seq
                if (i == 0)
                {
                    sameseq = 1;
                }
                else if (ch != s[i - 1])
                {
                    if (sameseq >= 3)
                    {
                        // if shorter length, add char into repeated seq
                        while (sLen + ricount < 6 && sameseq >= 3)
                        {
                            ricount++;
                            sameseq -= 2;
                        }
                        // if longer length, remove char from repeated seq
                        while (sLen - rdcount > 20 && sameseq >= 3)
                        {
                            rdcount++;
                            sameseq--;
                        }
                        // if length matches, replace char in repeated seq
                        rcount += sameseq / 3;
                    }
                    sameseq = 1;
                }
                else
                {
                    sameseq++;
                }
            }

            // need check repeated seq after loop
            if (sameseq >= 3)
            {
                // as previous process
                while (sLen + ricount < 6 && sameseq >= 3)
                {
                    ricount++;
                    sameseq -= 2;
                }
                while (sLen - rdcount > 20 && sameseq >= 3)
                {
                    rdcount++;
                    sameseq--;
                }
                rcount += sameseq / 3;
            }

            int update = lnum + unum + dnum;
            int must = ricount + rcount;
            if (sLen + ricount < 6)
            {
                must += 6 - sLen - ricount;
            }
            if (sLen < 20)
            {
                return must > update ? must : update;
            }

            // if longer length, use below process
            if (sLen - rdcount > 20)
            {
                rdcount += sLen - rdcount - 20;
            }
            return rcount >= update ? rcount + rdcount : update + rdcount;

        }


        public int StrongPasswordChecker1(string s)
        {
            int charCount = s.Length, currentCharSeq = 0;
            int charAddOrReplaceOrRemove = 0;
            bool isLowerFound = false, isUpperFound = false, isDigitFound = false;
            char previousChar = ' ';
            List<int> seqValues = new List<int>();


            int charAddOrReplace = 0;

            for (int i = 0; i < charCount; i++)
            {
                char currentChar = s[i];

                if (char.IsLower(currentChar))
                {
                    if (!isLowerFound)
                        isLowerFound = true;
                }
                else if (char.IsUpper(currentChar))
                {
                    if (!isUpperFound)
                        isUpperFound = true;
                }
                else if (char.IsDigit(currentChar))
                {
                    if (!isDigitFound)
                        isDigitFound = true;
                }

                if (currentChar == previousChar)
                {
                    currentCharSeq++;

                    if (currentCharSeq > 2 && i == charCount - 1)
                        seqValues.Add(currentCharSeq);
                }
                else
                {
                    if (currentCharSeq > 2)
                        seqValues.Add(currentCharSeq);

                    currentCharSeq = 1;
                    previousChar = currentChar;
                }
            }

            if (!isLowerFound)
                charAddOrReplace++;
            if (!isUpperFound)
                charAddOrReplace++;
            if (!isDigitFound)
                charAddOrReplace++;

            if (charCount < 6)
            {
                int charAdd = (6 - charCount);
                int changesFound = 0;

                foreach (int seqCount in seqValues)
                {
                    if (seqCount == 3)
                    {
                        charAddOrReplaceOrRemove++;
                    }
                    else// assuming count > 3
                    {
                        int times = seqCount / 2 - 1;

                        if (seqCount % 2 == 0)//even 4,6,8,.. 
                        {
                            // Do charAddOrReplace 'times' times
                            if (charAddOrReplace > 0)
                            {
                                if (charAddOrReplace > times)
                                {
                                    changesFound += times;
                                    charAddOrReplace = charAddOrReplace - times;
                                }
                                else
                                {
                                    changesFound += charAddOrReplace;
                                    charAddOrReplace = times - charAddOrReplace;
                                }
                            }
                            else
                                charAddOrReplace++;
                        }
                        else//odd 5,7,9,..
                        {
                            if (charAddOrReplace > 0)
                            {
                                int charsPending = 0;

                                // Do Replace 'times' times
                                if (charAddOrReplace > times)
                                {
                                    charAddOrReplace = charAddOrReplace - times;
                                    changesFound += times;
                                }
                                else
                                {
                                    changesFound += charAddOrReplace;
                                    times = times - charAddOrReplace;

                                    if (charAdd > 1)
                                    {
                                        int addNeeded = times + 1;

                                        if (charAdd > addNeeded)
                                        {
                                            charAdd = charAdd - addNeeded;
                                            changesFound += addNeeded;
                                            times = 0;
                                        }
                                        else
                                        {
                                            //todo
                                            //changesFound = (charAdd/2)*2;//assign even no.
                                            //charAdd = charAdd % 2; // 0 or 1 should remain here
                                            //times = times-
                                        }
                                    }

                                    charAddOrReplace = times;
                                }
                            }
                            else
                                charAddOrReplace++;
                        }
                    }

                }


                return
                    charAdd > charAddOrReplace
                        ? charAdd > charAddOrReplaceOrRemove
                            ? charAdd
                            : charAddOrReplaceOrRemove
                        : charAddOrReplace > charAddOrReplaceOrRemove
                            ? charAddOrReplace
                            : charAddOrReplaceOrRemove +
                    changesFound;


            }
            else if (charCount > 20)
            {
                int charRemove = charCount - 20;

                return
                  (charAddOrReplace + charRemove) > charAddOrReplaceOrRemove
                      ? (charAddOrReplace + charRemove)
                      : charAddOrReplaceOrRemove;
            }
            else
                return
                    charAddOrReplaceOrRemove > charAddOrReplace
                    ? charAddOrReplaceOrRemove
                    : charAddOrReplace;
        }
    }
}
