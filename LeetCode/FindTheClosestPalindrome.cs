using System;

namespace LeetCode
{
    public class FindTheClosestPalindrome
    {
        public string NearestPalindromic(string n)
        {
            bool? isGreater;
            string minPalindromeString, maxPalindromeString;

            if (IsPalindrome(n))
            {
                minPalindromeString = GetPalindromeFromString(n, false);
                maxPalindromeString = GetPalindromeFromString(n, true);
            }
            else
            {
                string palindromStr = PreparePalindromeFromString(n, out isGreater);

                if (isGreater == true)
                {
                    minPalindromeString = GetPalindromeFromString(n, false);
                    maxPalindromeString = palindromStr;
                }
                else if (isGreater == false)
                {
                    minPalindromeString = palindromStr;
                    maxPalindromeString = GetPalindromeFromString(n, true);
                }
                else
                    return null;
            }

            long minDistance = Math.Abs(long.Parse(n) - long.Parse(minPalindromeString));
            long maxDistance = Math.Abs(long.Parse(maxPalindromeString) - long.Parse(n)); ;

            if (minDistance <= maxDistance)
                return minPalindromeString;
            else
                return maxPalindromeString;
        }

        private bool IsPalindrome(string n)
        {
            int strLength = n.Length;

            for (int i = 0; i < strLength / 2; i++)
                if (n[i] != n[(strLength - 1) - i])
                    return false;

            return true;
        }

        private string PreparePalindromeFromString(string n, out bool? isGreater)
        {
            isGreater = null;
            int strLength = n.Length;
            char[] charArray = n.ToCharArray();
            //int currentIndex = n.Length % 2 == 0 ? n.Length / 2 - 1 : n.Length / 2;

            for (int i = 0; i < strLength / 2; i++)
                if (charArray[(strLength - 1) - i] != charArray[i])
                {
                    isGreater = charArray[i] > charArray[(strLength - 1) - i];

                    charArray[(strLength - 1) - i] = charArray[i];
                }

            return new string(charArray);
        }

        private string GetPalindromeFromString(string n, bool isGreater)
        {
            bool? isCurrentGreater;

            if (isGreater)
                return PreparePalindromeFromString(GetMaxStringToCompare(n), out isCurrentGreater);
            else
                return PreparePalindromeFromString(GetMinStringToCompare(n), out isCurrentGreater);
        }

        private string GetMaxStringToCompare(string n)
        {
            int currentIndex = n.Length % 2 == 0 ? n.Length / 2 - 1 : n.Length / 2;
            char[] charArray = n.ToCharArray();

            if (charArray[currentIndex] == '9')
            {
                // Reset all the next values to '0'. 2999->3000,2993->3000,..
                // First reset all the after values to '0'
                if (currentIndex < n.Length - 1)
                {
                    int checkAndRestToZeroIndex = currentIndex + 1;

                    while (checkAndRestToZeroIndex < n.Length)
                    {
                        charArray[checkAndRestToZeroIndex] = '0';
                        checkAndRestToZeroIndex++;
                    };
                }

                // Then handle the actual value and before values to '0' 
                do
                {
                    charArray[currentIndex] = '0';
                    currentIndex--;
                } while (currentIndex != -1 && charArray[currentIndex] == '9');

                if (currentIndex == -1)
                    return new System.Text.StringBuilder(n.Length + 1)
                        .Append('1')
                        .Append(charArray).ToString();
            }

            charArray[currentIndex]++;

            return new string(charArray);
        }

        private string GetMinStringToCompare(string n)
        {
            char[] charArray = n.ToCharArray();
            int currentIndex = n.Length % 2 == 0 ? n.Length / 2 - 1 : n.Length / 2;

            if (charArray[currentIndex] == '0' ||
                (charArray[currentIndex] == '1' && currentIndex == 0 && charArray.Length > 1))
            {
                // Reset all the next values to '9'. 1000->999,..
                // First reset all the after values to '9'
                if (currentIndex < n.Length - 1)
                {
                    int checkAndRestToZeroIndex = currentIndex + 1;

                    while (checkAndRestToZeroIndex < n.Length)
                    {
                        charArray[checkAndRestToZeroIndex] = '9';
                        checkAndRestToZeroIndex++;
                    };
                }

                do
                {
                    charArray[currentIndex] = '9';
                    currentIndex--;
                } while (currentIndex != -1 && charArray[currentIndex] == '0');

                if ((currentIndex == 0 && charArray[currentIndex] == '1') || currentIndex == -1)
                    return new System.Text.StringBuilder(n.Length - 1)
                        .Append(charArray, 1, n.Length - 1)
                        .ToString();
            }

            charArray[currentIndex]--;

            return new string(charArray);
        }

        //public string NearestPalindromic(string n)
        //{
        //    string lowestNxtNumber = n, highestNxtNumber = n;

        //    while (lowestNxtNumber != null || highestNxtNumber != null)
        //    {
        //        lowestNxtNumber = NextNumber(lowestNxtNumber, false);

        //        if (IsPalindrome(lowestNxtNumber))
        //            return lowestNxtNumber;

        //        highestNxtNumber = NextNumber(highestNxtNumber, true);

        //        if (IsPalindrome(highestNxtNumber))
        //            return highestNxtNumber;
        //    }

        //    return null;
        //}

        private string NextNumber(string str, bool isIncrement)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            char[] charArr = str.ToCharArray();
            int currentIndex = charArr.Length - 1;

            if (isIncrement)
            {
                while (currentIndex != -1 && charArr[currentIndex] == '9')
                {
                    charArr[currentIndex] = '0';
                    currentIndex--;
                }

                if (currentIndex == -1)
                    if (charArr.Length + 1 > 18)
                        return null;
                    else
                        return
                            new System.Text.StringBuilder(charArr.Length + 1)
                                .Append('1')
                                .Append(new string(charArr))
                                .ToString();

                charArr[currentIndex]++;
            }
            else
            {
                while (currentIndex != 0 && charArr[currentIndex] == '0')
                {
                    charArr[currentIndex] = '9';
                    currentIndex--;
                }

                charArr[currentIndex]--;

                // As only positive numbers are allowed
                if (currentIndex == 0 && charArr[currentIndex] == '0' && charArr.Length != 1)
                    return new string(charArr, 1, charArr.Length - 1);
            }

            return new string(charArr);
        }

        //private bool IsPalindrome(string str)
        //{
        //    if (str == null)
        //        return false;

        //    int strLength = str.Length;

        //    for (int i = 0; i < strLength / 2; i++)
        //        if (str[i] != str[(strLength - 1) - i])
        //            return false;

        //    return true;
        //}
    }
}
