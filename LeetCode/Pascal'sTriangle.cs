using System.Collections.Generic;

namespace LeetCode
{
    public class Pascal_sTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<int> prev = null;

            for (int i = 0; i < numRows; i++)
            {
                var current = new List<int>();

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                        current.Add(1);
                    else
                        current.Add(prev[j - 1] + prev[j]);
                }

                list.Add(current);
                prev = current;
            }

            return list;
        }
    }
}
