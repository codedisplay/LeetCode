using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class JumpGameIITests
    {
        [TestMethod]
        public void Jump()
        {
            JumpGameII l = new JumpGameII();

            int[] A = new int[] { 2, 3, 1, 1, 4 };//2
            Assert.AreEqual(l.Jump(A),2);

            int[] a = new int[] { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };
            Assert.AreEqual(l.Jump(a),2);

            a = new int[] { 3, 4, 3, 2, 5, 4, 3 };//3
            Assert.AreEqual(l.Jump(a),3);

            a = new int[] { 1, 2, 3 };//2
            Assert.AreEqual(l.Jump(a),2);

            a = new int[] { 5, 2, 1, 2, 5, 2, 6, 8, 1, 9, 3, 5, 8, 0, 2 };
            Assert.AreEqual(l.Jump(a),3);

            a = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 0 };
            Assert.AreEqual(l.Jump(a),2);

            a = new int[] { 2, 3, 1 };//1
            Assert.AreEqual(l.Jump(a),1);
        }
    }
}
