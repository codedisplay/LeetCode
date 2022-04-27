using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ShuffleString
    {
        //Runtime: 128 ms, faster than 5%
        public string RestoreString(string s, int[] indices)
        {
            char[] arr = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
                arr[indices[i]] = s[i];

            return new string(arr);
        }

        //        Runtime: 128 ms, faster than 63.09% of C# online submissions for Shuffle String.
        //Memory Usage: 40.4 MB, less than 84.30% of C# online submissions for Shuffle String.
        //public string RestoreString(string s, int[] indices)
        //{
        //    char[] arr = s.ToCharArray();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int currentIndex = i;
        //        char prevValue = s[currentIndex];

        //        do
        //        {
        //            int nextIndex = indices[currentIndex];
        //            indices[currentIndex] = -indices[currentIndex];

        //            if (nextIndex < 0)
        //                continue;

        //            char temp = s[nextIndex];
        //            arr[nextIndex] = prevValue;

        //            currentIndex = nextIndex;
        //            prevValue = temp;
        //        } while (currentIndex != i);
        //    }

        //    return new string(arr);
        //}
    }
}
