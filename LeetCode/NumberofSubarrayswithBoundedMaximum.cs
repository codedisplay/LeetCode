using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumberofSubarrayswithBoundedMaximum
    {
        public int NumSubarrayBoundedMax(int[] A, int L, int R)
        {
            int s = 0, e = 0, count = 0;
            int currentMax = int.MinValue;

            int sExclude = -1, eExclude = -3, excludeCount=0;//for removing the ranges from subarry which hav highest condition failing


            for (int i = 0; i < A.Length; i++)
            {
                int curr = A[i];

                if (curr < L)
                {
                    if (sExclude == -1)
                    {
                        sExclude = i;
                        eExclude = i;
                    }
                    else
                        eExclude = i;
                }
                else
                {
                    excludeCount += GetSubArrayCount(eExclude - sExclude + 1);
                    sExclude = -1;
                    eExclude = -3;
                }

                if (curr < currentMax)
                {
                    e = i;
                }
                else if (curr > R)
                {
                    if (e != i)
                    {
                        count += GetSubArrayCount(e - s + 1)//total count
                            - excludeCount //prev count in the sub array if any
                            - GetSubArrayCount(eExclude - sExclude + 1);//handle current count in sub array if any;
                        sExclude = -1;
                        eExclude = -3;
                        excludeCount = 0;
                    }

                    s = i + 1;
                    e = i + 1;
                    currentMax = int.MinValue;
                }
                else
                {
                    currentMax = curr;
                    e = i;
                }
            }

            if (e == A.Length - 1)
                count += GetSubArrayCount(e - s + 1)//total count
                   - excludeCount //prev count in the sub array if any
                   - GetSubArrayCount(eExclude - sExclude + 1);//handle current count in sub array if any;


            return count;
        }

        public int GetSubArrayCount(int n)
        {
            if (n < 0)
                return 0;

                return (n * (n + 1) / 2);
        }

        //public int GetSubArrayCount(int n, int excludeCount)
        //{
        //    return (n * (n + 1) / 2) - (excludeCount * (excludeCount + 1) / 2);
        //}
    }
}
