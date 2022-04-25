using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TaskScheduler
    {
        //TODO with priority queue
        public int LeastInterval(char[] tasks, int n)
        {
            int[] countArr = new int[27];
            int totalInterval = 0;

            for (int i = 0; i < tasks.Length; i++)
                countArr[tasks[i] - 'A']++;

            Array.Sort(countArr, delegate(int c1, int c2) {
                return c2.CompareTo(c1);
            });

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < countArr.Length; i++)
            {
                if (countArr[i] == 0)
                    break;

                queue.Enqueue(countArr[i]);
            }

            while (queue.Count > 0)
            {
                
            }

            return totalInterval;
        }
    }
}
