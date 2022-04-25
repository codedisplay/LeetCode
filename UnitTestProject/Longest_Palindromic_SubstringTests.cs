using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class Longest_Palindromic_SubstringTests
    {
        [TestMethod]
        public void LongestPalindromicSubstringTests()
        {
            Longest_Palindromic_Substring obj = new Longest_Palindromic_Substring();

            ////Input: "cbbd"
            ////Output: "bb"
            var x = obj.LongestPalindrome("cbbd");

            x = obj.LongestPalindrome("");//0

            x = obj.LongestPalindrome("bb");
            x = obj.LongestPalindrome("abb");

            x = obj.LongestPalindrome("abbbba");
        }
    }
}