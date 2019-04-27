using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CoinChange2Tests
    {
        [TestMethod]
        public void TrimBSTTests()
        {
            CoinChange2 obj = new CoinChange2();

            var x = obj.Change(12, new int[] { 1, 2, 5 });

            //Assert.AreEqual(x,);

            x = obj.Change1(12, new int[] { 1, 2, 5 });
        }
    }
}
