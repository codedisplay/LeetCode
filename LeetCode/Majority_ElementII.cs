using System.Collections.Generic;

namespace LeetCode
{
    public class Majority_ElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
                return new List<int>();

            int element1 = 0, element2 = 0, count1 = 0, count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (element1 == nums[i])
                    count1++;
                else if (element2 == nums[i])
                    count2++;
                else if (count1 == 0)
                {
                    element1 = nums[i];
                    count1++;
                }
                else if (count2 == 0)
                {
                    element2 = nums[i];
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            if (element1 == element2)
                return new List<int>() { element1 };

            count1 = 0;
            count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == element1) count1++;
                else if (nums[i] == element2) count2++;
            }

            IList<int> list = new List<int>();
            if (count1 > nums.Length / 3) list.Add(element1);
            if (count2 > nums.Length / 3) list.Add(element2);
            return list;
        }
    }
}
