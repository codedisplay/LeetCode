using System;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            double max = 0;

            while (left < right)
            {
                max = Math.Max(Math.Min(height[left], height[right]) * (right - left), max);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return (int)max;
        }
    }
}
