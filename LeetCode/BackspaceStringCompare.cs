using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BackspaceStringCompare
    {
        // can be improved by modifying stack to char[] and handling the end index value
        public bool BackspaceCompare(string S, string T)
        {
            Stack<char> arr1 = new Stack<char>();
            Stack<char> arr2 = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#')
                {
                    if (arr1.Count > 0)

                        arr1.Pop();
                }
                else
                    arr1.Push(S[i]);
            }

            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == '#')
                {
                    if (arr2.Count > 0)
                        arr2.Pop();
                }
                else
                    arr2.Push(T[i]);
            }

            if (arr1.Count != arr2.Count)
                return false;

            var len = arr1.Count;
            for (int i = 0; i < len; i++)
            {
                var char1 = arr1.Pop();
                var char2 = arr2.Pop();
      
                if (char1 != char2)
                    return false;
            }

            return true;
        }
    }
}
