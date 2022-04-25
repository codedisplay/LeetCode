using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CheckIfNandItsDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> lookup = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var cur = arr[i];
                if (lookup.Contains(cur) && cur != 0)
                    continue;

                if (cur % 2 == 0)
                {
                    if (lookup.Contains(cur / 2) || lookup.Contains(cur * 2))
                        return true;
                }
                else//odd
                {
                    if (lookup.Contains(cur * 2))
                        return true;
                }

                lookup.Add(cur);
            }

            return false;
        }
    }
}
