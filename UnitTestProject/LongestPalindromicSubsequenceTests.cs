using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LongestPalindromicSubsequenceTests
    {
        [TestMethod]
        public void LongestPalindromeSubseqTests()
        {
            LongestPalindromicSubsequence obj = new LongestPalindromicSubsequence();

            var str = "bbbab";
            var x = obj.LongestPalindromeSubseq(str);//4

            str = "cbbd";
            x = obj.LongestPalindromeSubseq(str);//2

            str = "abab";
            x = obj.LongestPalindromeSubseq(str);//3

            str = "a";
            x = obj.LongestPalindromeSubseq(str);//1

            str = "";
            x = obj.LongestPalindromeSubseq(str);//0
        }
    }
}
