using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class To_LowerCaseTests
    {
        [TestMethod]
        public void ToLowerCaseTests()
        {
            To_LowerCase obj = new To_LowerCase();

            var x = obj.ToLowerCase("Hello");

            x = obj.ToLowerCase("");

            x = obj.ToLowerCase("  ");

            x = obj.ToLowerCase("hello");

            x = obj.ToLowerCase("LOVELY");
        }
    }
}
