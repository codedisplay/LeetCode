using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Array_NestingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = new int[] { 5, 4, 0, 3, 1, 6, 2 };

            Array_Nesting l = new Array_Nesting();

            Assert.AreEqual(4,l.ArrayNesting(A));
        }
    }
}
