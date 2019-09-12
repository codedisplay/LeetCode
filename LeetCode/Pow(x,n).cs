using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Pow_x_n_
    {
        public double MyPow(double x, int n)
        {
            long p;// to handle n value like int.MinValue 
            if (n < 0)
            {
                x = 1 / x;
                p = -n;
            }
            else
                p = n;

            return MyPow(x, p);
        }

        private double MyPow(double x, long n)
        {
            if (n == 0)
                return 1;

            return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}
