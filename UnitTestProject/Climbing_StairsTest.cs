using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Climbing_StairsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Climbing_Stairs l = new Climbing_Stairs();

            Assert.AreEqual(2,l.ClimbStairs(2));
            Assert.AreEqual(3, l.ClimbStairs(3));
            Assert.AreEqual(5, l.ClimbStairs(4));
            Assert.AreEqual(8, l.ClimbStairs(5));
        }
    }
}
