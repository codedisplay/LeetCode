using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class StringtoInteger
    {
        public int MyAtoi(string s)
        {
            HashSet<char> nums = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            bool? isMinusFound = null;
            short numberFoundStatus = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (!isMinusFound.HasValue)
                    if (s[i] == '+')
                    {
                        isMinusFound = false;
                        continue;
                    }
                    else if (s[i] == '-')
                    {
                        isMinusFound = true;
                        continue;
                    }

                if (numberFoundStatus == 0)
                {
                    if(nums.Contains(s[i]))
                    {
                        numberFoundStatus = 1;
                        sb.Append(s[i]);
                    }
                    else if (s[i] != ' ')
                    {
                        return 0;
                    }
                }
                else if (numberFoundStatus == 1)
                {
                    if (!nums.Contains(s[i]))
                        numberFoundStatus = 2;
                    else
                        sb.Append(s[i]);
                }
            }

            int len = sb.Length;
            if(len > 10)//int.MaxValue //10 digits
                return isMinusFound == true ? int.MinValue : int.MaxValue;

            long num = len > 0 ? Convert.ToInt64(sb.ToString()) : 0;
            return isMinusFound == true 
                ? -num < int.MinValue ? int.MinValue : -Convert.ToInt32(num)
                : num > int.MaxValue ? int.MaxValue : Convert.ToInt32(num);
        }

        //public int MyAtoi(string s)
        //{
        //    HashSet<char> nums = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        //    bool? isMinusFound = null;
        //    int lastIndex = -1, firstIndex = -1;
        //    short numberFoundStatus = 0;
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!isMinusFound.HasValue)
        //            if (s[i] == '+')
        //            {
        //                isMinusFound = false;
        //                continue;
        //            }
        //            else if (s[i] == '-')
        //            {
        //                isMinusFound = true;
        //                continue;
        //            }

        //        if (numberFoundStatus == 0)
        //        {
        //            if (nums.Contains(s[i]))
        //            {
        //                firstIndex = i;
        //                lastIndex = i;
        //                numberFoundStatus = 1;
        //                sb.Append(s[i]);
        //            }
        //        }
        //        else if (numberFoundStatus == 1)
        //        {
        //            if (!nums.Contains(s[i]))
        //                numberFoundStatus = 2;
        //            else
        //                sb.Append(s[i]);

        //            lastIndex = i;
        //        }
        //    }

        //    int len = lastIndex - firstIndex + 1;

        //    if (len > 10)//int.MaxValue //10 digits
        //        return isMinusFound == true ? int.MinValue : int.MaxValue;

        //    //long num = Convert.ToInt64(s.Substring(firstIndex, len));
        //    long num = Convert.ToInt64(sb.ToString());

        //    return isMinusFound == true
        //        ? -num < int.MinValue ? int.MinValue : -Convert.ToInt32(num)
        //        : num > int.MaxValue ? int.MaxValue : Convert.ToInt32(num);
        //}
    }
}
