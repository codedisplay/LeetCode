using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSum
    {
        private HashSet<int> list;
        private HashSet<int> duplicateList;

        /** Initialize your data structure here. */
        public TwoSum()
        {
            list = new HashSet<int>();
            duplicateList = new HashSet<int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (!list.Contains(number))
                list.Add(number);
            else if (!duplicateList.Contains(number))
                duplicateList.Add(number);
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach (int item in list)
            {
                if (list.Contains(value - item))
                {
                    if (value - item == item) // check for duplicates
                    {
                        if (duplicateList.Contains(item))
                            return true;
                    }
                    else
                        return true;
                }
            }

            return false;
        }
    }

    /**
     * Your TwoSum object will be instantiated and called as such:
     * TwoSum obj = new TwoSum();
     * obj.Add(number);
     * bool param_2 = obj.Find(value);
     */




}
