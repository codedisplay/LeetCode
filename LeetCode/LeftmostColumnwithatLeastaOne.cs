using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public interface BinaryMatrix
    {
        int Get(int row, int col);
        IList<int> Dimensions();
    }

  

    public class LeftmostColumnwithatLeastaOne
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var dimensions = binaryMatrix.Dimensions();
            int? currentMin = null;

            for (int i = 0; i < dimensions[0]; i++)//rows
            {
                if (binaryMatrix.Get(i, dimensions[1] - 1) == 0)
                    continue;

                int start = 0, end = currentMin.HasValue ? currentMin.Value : dimensions[1] - 1,mid;
                while ( start <= end )
                {
                    if (binaryMatrix.Get(i, end) != 1 || start < 0 || end >= dimensions[1])
                        break ;

                    mid = start + (end - start) / 2;

                    if (binaryMatrix.Get(i, start) == 1)
                    {
                        currentMin = start;
                        break;
                    }

                    if (binaryMatrix.Get(i, mid) == 1)
                    {
                        currentMin = mid;
                        end = mid - 1;
                    }
                    else
                    {
                        currentMin = end;
                        start = mid + 1;
                    }
                }
            }

            return currentMin.HasValue ? currentMin.Value : -1;
        }

        //public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        //{
        //    var dimensions = binaryMatrix.Dimensions();

        //    //if (dimensions.Count != 2 || dimensions[0] == 0 || dimensions[1] == 0
        //    //    || binaryMatrix.Get(dimensions[0] - 1, dimensions[1] - 1) == 0)
        //    //    return -1;

        //    List<int> validRowIndexes = new List<int>();

        //    for (int i = 0; i < dimensions[0]; i++)//rows
        //    {
        //        if (binaryMatrix.Get(i, dimensions[1] - 1) == 1)
        //            validRowIndexes.Add(i);
        //    }

        //    for (int j = 0; j < dimensions[1]; j++)//cols
        //    {
        //        for (int i = 0; i < validRowIndexes.Count; i++)//rows
        //        {
        //            if (binaryMatrix.Get(validRowIndexes[i], j) == 1)
        //                return j;
        //        }
        //    }

        //    return -1;
        //}
    }
}
