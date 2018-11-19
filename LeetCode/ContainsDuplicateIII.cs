using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    var val = keyValuePairs[nums[i]];
                    val.Add(i);
                }
                else
                {
                    var val = new List<int>() { i };
                    keyValuePairs[nums[i]] = val;
                }
            }

            return false;
        }
    }
}
