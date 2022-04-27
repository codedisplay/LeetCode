using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DefangingAnIPAddressTests
    {
        [TestMethod]
        public void DefangIPaddrTests()
        {
            DefangingAnIPAddress obj = new DefangingAnIPAddress();

            string address = "1.1.1.1";
            var x = obj.DefangIPaddr(address);//1[.]1[.]1[.]1

            address = "255.100.50.0";
            x = obj.DefangIPaddr(address);//255[.]100[.]50[.]0
        }
    }
}
