using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return intervals;

            List<int[]> list = new List<int[]>();
            Array.Sort(intervals, new SortNestedArrayClass());
            int i = 0, start, end;

            while (i < intervals.Length)
            {
                start = intervals[i][0];
                end = intervals[i][1];
                i++;

                while (i < intervals.Length && end >= intervals[i][0])
                {
                    end = Math.Max(intervals[i][1], end);
                    i++;
                }

                list.Add(new int[] { start, end });
            }

            return list.ToArray();
        }

        public class SortNestedArrayClass : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] > y[0])
                    return 1;
                else if (x[0] < y[0])
                    return -1;
                else if (x[1] > y[1])
                    return 1;
                else if (x[1] < y[1])
                    return -1;
                else
                    return 0;
            }
        }
    }
}
