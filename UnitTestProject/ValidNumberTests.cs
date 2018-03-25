using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ValidNumberTests
    {
        [TestMethod]
        public void ValidNumberTest()
        {
            ValidNumber l = new ValidNumber();

            Assert.IsTrue(l.IsNumber(" 0.1 "));
            Assert.IsTrue(l.IsNumber("0"));
            Assert.IsTrue(l.IsNumber("-124"));
            Assert.IsTrue(l.IsNumber("12."));
            Assert.IsTrue(l.IsNumber("2e0"));
            Assert.IsTrue(l.IsNumber("46.e3"));
            Assert.IsTrue(l.IsNumber("32.e-80123"));

            Assert.IsFalse(l.IsNumber("459277e38+"));
            Assert.IsFalse(l.IsNumber("-124.23.23"));
            Assert.IsFalse(l.IsNumber("-"));
            Assert.IsFalse(l.IsNumber("."));
            Assert.IsFalse(l.IsNumber("12 12"));
            Assert.IsFalse(l.IsNumber("++2"));
            Assert.IsFalse(l.IsNumber(""));
            Assert.IsFalse(l.IsNumber(".-4"));
            Assert.IsFalse(l.IsNumber("abc"));
            Assert.IsFalse(l.IsNumber("1 a"));
            Assert.IsFalse(l.IsNumber("0efd"));
        }
    }
}
