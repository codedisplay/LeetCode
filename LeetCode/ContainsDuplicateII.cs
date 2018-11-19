using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    var val = keyValuePairs[nums[i]];

                    for (int j = val.Count - 1; j >= 0; j--)
                    {
                        if (i - val[j] <= k)
                            return true;
                    }

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
