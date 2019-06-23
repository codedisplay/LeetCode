using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Word_BreakTests
    {
        [TestMethod]
        public void WordBreakTests()
        {
            Word_Break obj = new Word_Break();
            string s = "leetcode";
            string[] wordDict = new string[] { "leet", "code" };
            var x = obj.WordBreak(s, wordDict);//T

            s = "applepenapple";
            wordDict = new string[] { "apple", "pen" };
            x = obj.WordBreak(s, wordDict);//T

            s = "catsandog";
            wordDict = new string[] { "cats", "dog", "sand", "and", "cat" };
            x = obj.WordBreak(s, wordDict);//F

            s = "aaaaaaa";
            wordDict = new string[] { "aaaa", "aaa" };
            x = obj.WordBreak(s, wordDict);//T

            s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab";
            wordDict = new string[] { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" };
            x = obj.WordBreak(s, wordDict);//
        }
    }
}
