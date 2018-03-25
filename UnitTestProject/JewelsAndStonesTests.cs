using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class JewelsAndStonesTests
    {
        [TestMethod]
        public void NumJewelsInStonesTest()
        {
            JewelsAndStones l = new JewelsAndStones();

            string J = "aA", S = "aAAbbbb";

            Assert.AreEqual(3, l.NumJewelsInStones(J, S));

            J = "z";
            S = "ZZ";
            Assert.AreEqual(0, l.NumJewelsInStones(J, S));
        }
    }
}
