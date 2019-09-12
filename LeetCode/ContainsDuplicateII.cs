using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    if (i - keyValuePairs[nums[i]] <= k)
                        return true;

                    keyValuePairs[nums[i]] = i;
                }
                else
                {
                    keyValuePairs.Add(nums[i],i);
                }
            }

            return false;
        }

        // working using Dictionary<int, List<int>> memory
        //public bool ContainsNearbyDuplicate(int[] nums, int k)
        //{
        //    Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (keyValuePairs.ContainsKey(nums[i]))
        //        {
        //            var val = keyValuePairs[nums[i]];

        //            for (int j = val.Count - 1; j >= 0; j--)
        //            {
        //                if (i - val[j] <= k)
        //                    return true;
        //                else if (j - i > k)
        //                    break;
        //            }

        //            val.Add(i);
        //        }
        //        else
        //        {
        //            var val = new List<int>() { i };
        //            keyValuePairs[nums[i]] = val;
        //        }
        //    }

        //    return false;
        //}
    }
}
