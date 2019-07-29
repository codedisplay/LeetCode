using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SmallestSubsequenceofDistinctCharactersTests
    {
        [TestMethod]
        public void SmallestSubsequenceTests()
        {
            SmallestSubsequenceofDistinctCharacters obj = new SmallestSubsequenceofDistinctCharacters();

            string num1 = "leetcode";
            var x = obj.SmallestSubsequence(num1);//letcod

            num1 = "cdadabcc";
            x = obj.SmallestSubsequence(num1);//adbc

            num1 = "abcd";
            x = obj.SmallestSubsequence(num1);//abcd

            num1 = "ecbacba";
            x = obj.SmallestSubsequence(num1);//eacb
        }
    }
}
