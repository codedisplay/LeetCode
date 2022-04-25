using System;
using System.Collections.Generic;
using static LeetCode.CountUnivalueSubtrees;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = MaxTickets(new List<int> { 8, 5, 4, 8, 4 });
            x = MaxTickets(new List<int> { 4, 4, 13, 2, 3 });

            //var x = CommonPrefix(new List<string> {"abcabcd" });
            //x = CommonPrefix(new List<string> { "ababaa" });


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static int MaxTickets(List<int> tickets)
        {
            if (tickets.Count < 2)
                return tickets.Count;

            int max = 0;

            // As tickets needs to be sorted 
            tickets.Sort();

            int prev = 0;
            int? curr = null;

            for (int i = 1; i < tickets.Count; i++)
            {
                if (tickets[prev] == tickets[i])
                {
                    max = Math.Max(max, i - prev + 1);
                    continue;

                }

                if (tickets[prev] + 1 == tickets[i])
                {
                    curr = i;
                    max = Math.Max(max, i - prev + 1);
                    continue;
                }

                prev = curr.HasValue ? curr.Value : i;
                curr = null;

            }

            return max;
        }

        public static List<int> CommonPrefix(List<string> inputs)
        {
            List<int> prefixList = new List<int>();

            foreach (var str in inputs)
            {
                int strLen = str.Length;//empty prefix scneario

                for (int i = 0; i < str.Length; i++)
                {
                    int len = 0;
                    int o = 0;

                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[o] == str[j])
                            len++;
                        else
                        {
                            break;
                        }

                        o++;
                    }
                    strLen += len;
                }

                prefixList.Add(strLen);
            }

            return prefixList;
        }

        //public static int maxLenSub(int[] arr)
        //{
        //    int n = arr.Length, max = 0;
        //    int[] mls = new int[n];

        //    Array.Sort(arr);

        //    for (int i = 0; i < n; i++)
        //        mls[i] = 1;

        //    for (int i = 1; i < n; i++)
        //        for (int j = 0; j < i; j++)
        //            if (Math.Abs(arr[i] - arr[j]) <= 1
        //                && mls[i] < mls[j] + 1)
        //                mls[i] = mls[j] + 1;

        //    for (int i = 0; i < n; i++)
        //        if (max < mls[i])
        //            max = mls[i];

        //    return max;
        //}



        //public int Solution(int[] A)
        //{
        //    write your code in C# 6.0 with .NET 4.5 (Mono)
        //    Array.Sort(A);

        //    int val = 1;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] > 0)
        //            if (val == A[i])
        //                val++;
        //            else if (val < A[i])
        //                return val;
        //    }

        //    return val;
        //}
    }
}
