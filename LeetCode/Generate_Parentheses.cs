using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Generate_Parentheses
    {
        //TODO
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> values = new List<string>();

            if (n == 0)
            {
                values.Add("");
                return values;
            }
            else if (n == 1)
            {
                values.Add("()");
                return values;
            }

            for (int i = 1; i < n; i++)
            {
                var x = GenerateParenthesis(i);
                var y = GenerateParenthesis(n - i);

                foreach (var x1 in x)
                {
                    foreach (var y1 in y)
                    {
                        values.Add(string.Concat(x1, y1));
                    }
                }
            }

            return values;
        }

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
