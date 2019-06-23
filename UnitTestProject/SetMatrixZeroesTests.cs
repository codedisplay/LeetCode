using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SetMatrixZeroesTests
    {
        [TestMethod]
        public void SpiralOrderTests()
        {
            SetMatrixZeroes obj = new SetMatrixZeroes();

            int[][] array2D = new int[][]
                                {
                                    new int[] { 1, 1, 1 },
                                    new int[] { 1, 0, 1 },
                                    new int[] { 1, 1, 1 }
                                };

            //        Output:
            //[
            //  [1, 0, 1],
            //  [0,0,0],
            //  [1,0,1]
            //]
            obj.SetZeroes(array2D);

            array2D = new int[][]
                                {
                                    new int[] { 0, 1, 2, 0 },
                                    new int[] { 3, 4, 5, 2 },
                                    new int[] { 1, 3, 1, 5 }
                                };

            //        Output:
            //[
            //  [0, 0, 0, 0],
            //  [0,4,5,0],
            //  [0,3,1,0]
            //]
            obj.SetZeroes(array2D);

            array2D = new int[][]
                    {
                        new int[] {1,0 }
                    };

            //        Output:
            // [[0,0]]
            obj.SetZeroes(array2D);

            array2D = new int[][]
        {
                        new int[] {1,0,3 }
        };

            //        Output:
            // [[0,0,0]]
            obj.SetZeroes(array2D);

        }
    }
}
