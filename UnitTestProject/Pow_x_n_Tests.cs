using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Pow_x_n_Tests
    {
        [TestMethod]
        public void NextGreatestLetterTests()
        {
            Pow_x_n_ obj = new Pow_x_n_();

            var x = obj.MyPow(2.00000, 10);
            //Assert.AreEqual(x, 1024.00000);

            x = obj.MyPow(2.10000, 3);
            //Assert.AreEqual(x, 9.26100);

            x = obj.MyPow(2.00000, -2);
            //Assert.AreEqual(x, 0.25000);

            x = obj.MyPow(2.00000, 0);
            //Assert.AreEqual(x, 1);

            x = obj.MyPow(2.00000,int.MinValue);//0
        }

    }
}
