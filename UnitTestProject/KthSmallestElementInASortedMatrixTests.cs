using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class KthSmallestElementInASortedMatrixTests
    {
        [TestMethod]
        public void KthSmallestTests()
        {
            KthSmallestElementInASortedMatrix obj = new KthSmallestElementInASortedMatrix();

            int[,] array2D = new int[,] { { 1, 5, 9 }, { 10, 11, 13 }, { 12, 13, 15 } };

            var x = obj.KthSmallest(array2D, 8);

            array2D = new int[,] { { -5 } };

            x = obj.KthSmallest(array2D, 1);
        }
    }
}
