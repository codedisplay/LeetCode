using System.Collections.Generic;

namespace LeetCode
{
    public class Majority_ElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
                return new List<int>();

            int first = 0, second = 0, count1 = 0, count2 = 0;

            for (int i = 0; i < nums.Length; i++)// find two numbers
            {
                if (first == nums[i])
                    count1++;
                else if (second == nums[i])
                    count2++;
                else if (count1 == 0)
                {
                    first = nums[i];
                    count1++;
                }
                else if (count2 == 0)
                {
                    second = nums[i];
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            if (first == second)
                return new List<int>() { first };

            count1 = 0;
            count2 = 0;

            for (int i = 0; i < nums.Length; i++)// find actual count of two numbers
            {
                if (nums[i] == first)
                    count1++;
                else if (nums[i] == second)
                    count2++;
            }

            IList<int> list = new List<int>();

            if (count1 > nums.Length / 3)
                list.Add(first);
            if (count2 > nums.Length / 3)
                list.Add(second);

            return list;
        }
    }
}
