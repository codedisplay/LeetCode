using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class SumofSubarrayMinimums
    {
        public int SumSubarrayMins(int[] A)
        {
            int ans=0,  mod = (int) 1e9 + 7;  
            Stack<int> outerStack = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                outerStack.Push(A[i]);
                ans = (ans + A[i])% mod;
            }

            while (outerStack.Count > 0)
            {
                Stack<int> innerStack = outerStack;
                outerStack = new Stack<int>();

                int prev = innerStack.Pop();

                while (innerStack.Count > 0)
                {
                    int current = innerStack.Pop();

                    int min = Math.Min(prev,current);
                    prev = current;

                    outerStack.Push(min);
                    ans = (ans + min) % mod;
                }                
            }

            return ans;
        }
    }
}
