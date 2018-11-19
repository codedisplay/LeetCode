using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SmallestRange_ITests
    {
        [TestMethod]
        public void SmallestRangeITests()
        {
            SmallestRange_I obj = new SmallestRange_I();

            var A = new int[] { 1 };
            int K = 0;

            var r = obj.SmallestRangeI(A, K);

            A = new int[] { 0, 10 };
            K = 2;

            r = obj.SmallestRangeI(A, K);

            A = new int[] { 1, 3, 6 };
            K = 3;

            r = obj.SmallestRangeI(A, K);
        }
    }
}
