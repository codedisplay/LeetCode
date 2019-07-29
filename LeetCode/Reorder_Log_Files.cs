using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Reorder_Log_Files
    {
        //TODO
        public string[] ReorderLogFiles(string[] logs)
        {
            Array.Sort(logs, new SortStringArrayClass());
            return logs;
        }

        private class SortStringArrayClass : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                int xI = x.IndexOf(' ') + 1, yI = y.IndexOf(' ') + 1;

                if (char.IsDigit(y[yI]) && char.IsDigit(x[xI]))
                    return 0;
                if (char.IsDigit(y[yI]))
                    return -1;
                if (char.IsDigit(x[xI]))
                    return 1;

                while (true)
                {
                    if (x[xI] > y[yI])
                        return 1;
                    if (x[xI] < y[yI])
                        return -1;

                    xI++;
                    yI++;

                    if (!(xI < x.Length && yI < y.Length))
                    {
                        xI = 0;
                        yI = 0;
                    }
                }
            }
        }
    }
}
