﻿namespace LeetCode
{
    public class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int len = 0;
            int i = 0;

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[len] = nums[i];
                    len++;
                }
            }

            return len;
        }
    }
}
