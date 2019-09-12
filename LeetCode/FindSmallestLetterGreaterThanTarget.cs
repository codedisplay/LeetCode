using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int start = 0, end = letters.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (letters[mid] <= target)
                    start = mid + 1;
                else if (mid == 0 || letters[mid - 1] <= target)
                    return letters[mid];
                else
                    end = mid - 1;
            }

            return letters[0];
        }
    }
}

