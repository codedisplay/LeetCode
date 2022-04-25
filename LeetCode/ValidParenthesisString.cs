using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ValidParenthesisString
    {
        //Best Solution
        //public bool CheckValidString(String s)
        //{
        //    int minOpen = 0, maxOpen = 0;

        //    foreach (char c in s)
        //    {
        //        if (c == '(')
        //        {
        //            minOpen++;
        //            maxOpen++;
        //        }
        //        else if (c == ')')
        //        {
        //            minOpen--;
        //            maxOpen--;
        //        }
        //        else
        //        {
        //            minOpen--;
        //            maxOpen++;
        //        }

        //        if (maxOpen < 0)
        //            return false;

        //        minOpen = Math.Max(minOpen, 0);
        //    }
        //    return minOpen == 0;
        //}

        // other solution 
        public bool CheckValidString(String s)
        {
            int leftBalance = 0;
            foreach (char c in s)
            {
                if (c == '(' || c == '*')
                    leftBalance++;
                else
                    leftBalance--;

                if (leftBalance < 0)
                    return false;
            }

            if (leftBalance == 0)
                return true;

            int rightBalance = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ')' || s[i] == '*')
                    rightBalance++;
                else
                    rightBalance--;

                if (rightBalance < 0)
                    return false;
            }

            return true;
        }

        //public bool CheckValidString(string s)
        //{
        //    int lifelines = 0;
        //    int openCount = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        switch (s[i])
        //        {
        //            case '(':
        //                openCount++;
        //                break;
        //            case ')':
        //                if (openCount == 0)
        //                    if (lifelines == 0)
        //                        return false;
        //                    else
        //                    {
        //                        lifelines--;
        //                        break;
        //                    }    

        //                openCount--;
        //                break;
        //            default:
        //                lifelines++;
        //                break;
        //        }
        //    }

        //    return Math.Max(0, openCount - lifelines) == 0;
        //}
    }
}
