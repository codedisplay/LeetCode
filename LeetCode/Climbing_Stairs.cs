using System.Collections.Generic;

namespace LeetCode
{
    public class Climbing_Stairs
    {
        // Memoization  todo
        public int ClimbStairs(int n)
        {
            if (n < 4)
                return n;

            int[] arr = new int[n];

            //ClimbStairs(n, arr);

            return arr[n];
        }

        //private int ClimbStairs(int n, int[] arr)
        //{

        //    return ClimbStairs(n-1,arr) + ClimbStairs(n - 2, arr);
        //}



        // Dynamic Programming- working
        //public int ClimbStairs(int n)
        //{
        //    if (n < 4)
        //        return n;

        //    int[] arr = new int[n + 1];
        //    arr[1] = 1;
        //    arr[2] = 2;

        //    for (int i = 3; i <= n; i++)
        //    {
        //        arr[i] = arr[i - 2] + arr[i - 1];
        //    }

        //    return arr[n];
        //}
    }
}
