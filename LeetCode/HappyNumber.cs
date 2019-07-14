using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> list = new HashSet<int>();

            while (n != 1)
            {
                int val = 0;

                while (n != 0)
                {
                    val += (int)Math.Pow(n % 10, 2);
                    n = n / 10;
                }

                if (list.Contains(val))
                    return false;
                else
                    list.Add(val);

                n = val;
            }

            return true;
        }
    }
}
