using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Generate_Parentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();

            if (n == 0)
                return list;

            char[] arr = new char[n * 2];

            GenerateParenthesis(arr, n, 0, (n * 2) - 1, list);

            return list;
        }

        public void GenerateParenthesis(char[] S, int n, int start, int end, IList<string> list)
        {
            if (start >= end)
            {
                if (start == end + 1)
                    list.Add(new string(S));
                return;
            }

            if (n > 1)
            {
                S[start] = '(';
                S[start + 1] = ')';
                GenerateParenthesis(S, n - 1, start + 2, end, list);//()_

                if (n > 2)
                {
                    S[end - 1] = '(';
                    S[end] = ')';
                    GenerateParenthesis(S, n - 1, start, end - 2, list);//_()
                }

            }
            else
            {

                S[start] = '(';
                S[end] = ')';
                GenerateParenthesis(S, n - 1, start + 1, end - 1, list);//(_)
            }
        }
        //TODO
        //public IList<string> GenerateParenthesis(int n)
        //{
        //    IList<string> values = new List<string>();

        //    if (n == 0)
        //    {
        //        values.Add("");
        //        return values;
        //    }
        //    else if (n == 1)
        //    {
        //        values.Add("()");
        //        return values;
        //    }

        //    for (int i = 1; i < n; i++)
        //    {
        //        var x = GenerateParenthesis(i);
        //        var y = GenerateParenthesis(n - i);

        //        foreach (var x1 in x)
        //        {
        //            foreach (var y1 in y)
        //            {
        //                values.Add(string.Concat(x1, y1));
        //            }
        //        }
        //    }

        //    return values;
        //}

        //public IList<string> GenerateParenthesis(int n)
        //{
        //    IList<string> values = new List<string>();

        //    if (n == 0)
        //        return values;
        //    else if (n == 1)
        //    {
        //        values.Add("()");
        //        return values;
        //    }

        //    var resp = GenerateParenthesis(--n);

        //    foreach (var val in resp)
        //    {
        //        values.Add(string.Concat(val, "()"));

        //        if (!values.Contains(string.Concat("()", val)))
        //            values.Add(string.Concat("()", val));

        //        values.Add(string.Concat("(", val, ")"));
        //    }

        //    return values;
        //}
    }
}
