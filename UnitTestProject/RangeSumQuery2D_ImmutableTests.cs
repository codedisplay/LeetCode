using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RangeSumQuery2D_ImmutableTests
    {
        [TestMethod]
        public void NumMatrixTests()
        {

            /**
             * Your NumMatrix object will be instantiated and called as such:
             * NumMatrix obj = new NumMatrix(matrix);
             * int param_1 = obj.SumRegion(row1,col1,row2,col2);
             * 
             * Given matrix = [
              [3, 0, 1, 4, 2],
              [5, 6, 3, 2, 1],
              [1, 2, 0, 1, 5],
              [4, 1, 0, 1, 7],
              [1, 0, 3, 0, 5]
            ]

            sumRegion(2, 1, 4, 3) -> 8
            sumRegion(1, 1, 2, 2) -> 11
            sumRegion(1, 2, 2, 4) -> 12
             */
            int[][] array2D = new int[][]
                                {
                                    new int[] { 3, 0, 1, 4, 2 },
                                    new int[] { 5, 6, 3, 2, 1 },
                                    new int[] { 1, 2, 0, 1, 5 },
                                    new int[] { 4, 1, 0, 1, 7 },
                                    new int[] { 1, 0, 3, 0, 5 },
                                };
            NumMatrix obj = new NumMatrix(array2D);

            int param_1 = obj.SumRegion(2, 1, 4, 3);
            param_1 = obj.SumRegion(1, 1, 2, 2);
            param_1 = obj.SumRegion(1, 2, 2, 4);
        }
    }
}
