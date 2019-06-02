using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SpiralMatrixIITests
    {
        [TestMethod]
        public void GenerateMatrixTests()
        {
            SpiralMatrixII obj = new SpiralMatrixII();

            var x = obj.GenerateMatrix(3);

            x = obj.GenerateMatrix(4);

            x = obj.GenerateMatrix(0);

            x = obj.GenerateMatrix(1);

            x = obj.GenerateMatrix(2);

            x = obj.GenerateMatrix(5);

        }
    }
}
