using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SubarraySumEqualsKTests
    {
        [TestMethod]
        public void SubarraySum()
        {
            SubarraySumEqualsK dp = new SubarraySumEqualsK();

            int[] A = new int[] { 1, 2, 3 };

            Assert.AreEqual(dp.SubarraySum(A, 5), 1);

            A = new int[] { 1, 1, 1 };

            Assert.AreEqual(dp.SubarraySum(A, 2), 2);

            A = new int[] { 2, 4, 6, 10 };

            Assert.AreEqual(dp.SubarraySum(A, 16), 1);

            A = new int[] { 2, 4, 6, 10, 16 };

            Assert.AreEqual(dp.SubarraySum(A, 16), 2);

            A = new int[] { 2, 4, 6, 10, 16 };

            Assert.AreEqual(dp.SubarraySum(A, 16), 2);

            A = new int[] { 10, 2,-2,-20,10 };

            Assert.AreEqual(dp.SubarraySum(A, -10), 3);

            A = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Assert.AreEqual(dp.SubarraySum(A, 0), 55);

            // for non continuous
            //int[] A = new int[] { 1, 2, 3 };

            //Assert.AreEqual(dp.SubarraySum(A, 5), 1);

            //A = new int[] { 1, 1, 1 };

            //Assert.AreEqual(dp.SubarraySum(A, 2), 3);

            //A = new int[] { 2, 4, 6, 10 };

            //Assert.AreEqual(dp.SubarraySum(A, 16), 2);

            //A = new int[] { 2, 4, 6, 10, 16 };

            //Assert.AreEqual(dp.SubarraySum(A, 16), 3);

            //A = new int[] { 2, 4, 6, 10, 16 };

            //Assert.AreEqual(dp.SubarraySum(A, 16), 3);
        }
    }
}
