using System.Collections.Generic;

namespace LeetCode
{
    public class Pascal_sTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> list = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
                list.Add(1);

            for (int i = 0; i <= rowIndex; i++)//each row
            {
                for (int j = i - 1; j > 0; j--)
                {
                    list[j] = list[j - 1] + list[j];
                }
            }

            return list;
        }
    }
}
