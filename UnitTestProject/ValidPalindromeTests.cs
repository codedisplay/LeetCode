using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ValidPalindromeTests
    {
        [TestMethod]
        public void MaximumProductTest()
        {
            //VERIFY: check best solution
            //ASCII 48-57 (0-9)
            // A-Z (65-90)
            // a-z (97-122)
            var s = "A man, a plan, a canal: Panama";
           Assert.IsTrue(ValidPalindrome.IsPalindrome(s));//t

            s = "race a car";
            Assert.IsFalse(ValidPalindrome.IsPalindrome(s));//t
        }
    }
}
