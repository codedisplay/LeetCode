using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int first = m - 1, second = n - 1, index = nums1.Length - 1;

            while (index >= 0)
            {
                if (first >= 0 && second >= 0)
                {
                    if (nums1[first] > nums2[second])
                    {
                        nums1[index] = nums1[first];
                        first--;
                    }
                    else
                    {
                        nums1[index] = nums2[second];
                        second--;
                    }
                }
                else if (second >= 0)
                {
                    nums1[index] = nums2[second];
                    second--;
                }
                else
                    break;

                index--;
            }
        }
    }
}
