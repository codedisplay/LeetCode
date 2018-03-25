using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void IsValidParentheses()
        {
            ValidParentheses l = new ValidParentheses();

            Assert.IsTrue(l.IsValid("()[]"));
            Assert.IsTrue(l.IsValid("[({})]"));
            Assert.IsTrue(l.IsValid("[({})]{}"));
            Assert.IsTrue(l.IsValid(""));

            Assert.IsFalse(l.IsValid("[[({})]"));
            Assert.IsFalse(l.IsValid("([)[]"));
            Assert.IsFalse(l.IsValid("([)]"));
            Assert.IsFalse(l.IsValid("{[{]]}{}[]"));
        }
    }
}
