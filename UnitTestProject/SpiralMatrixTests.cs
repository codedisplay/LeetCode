using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SpiralMatrixTests
    {
        [TestMethod]
        public void SpiralOrderTests()
        {
            SpiralMatrix obj = new SpiralMatrix();

            int[,] array2D = new int[,] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };

            var x = obj.SpiralOrder(array2D);


            array2D = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            x = obj.SpiralOrder(array2D);

            array2D = new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            x = obj.SpiralOrder(array2D);

            array2D = new int[,] { { 1, 2 }, { 4, 3 } };
            x = obj.SpiralOrder(array2D);
        }
    }
}
