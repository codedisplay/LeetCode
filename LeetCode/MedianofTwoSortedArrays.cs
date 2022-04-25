using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MedianofTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            bool isLenEven = (nums1.Length + nums2.Length) % 2 == 0;

            bool ignoreI = false;
            bool igonreJ = false;

            int lookupIndex = (nums1.Length + nums2.Length) / 2;

            int iStart = 0, iEnd = nums1.Length - 1;
            int jStart = 0, jEnd = nums2.Length - 1;


            int iReadCount = 0, jReadCount = 0;
            int currentVal = 0;
            while(true)
            {
                if (iEnd < jStart)
                {
                    if ((iEnd + jStart) <= lookupIndex)
                    {
                        currentVal = nums1[lookupIndex - jStart];
                        break;
                    }
                    else if ((nums1.Length -1 + jStart) <= lookupIndex)
                    {
                        currentVal = nums1[lookupIndex - nums1.Length -1];
                        break;
                    }
                }
            }

            return 0;
        }
    }
}
