using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PalindromeNumberTests
    {
        [TestMethod]
        public void IsPalindromeTests()
        {
            PalindromeNumber obj = new PalindromeNumber();

            var x = obj.IsPalindrome(121);//t

            x = obj.IsPalindrome(-121);//f

            x = obj.IsPalindrome(10);//f

            x = obj.IsPalindrome(10002);//f

            x = obj.IsPalindrome(10001);//t

        }
    }
}
