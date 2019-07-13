using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FirstUniqueCharacterinaStringTests
    {
        [TestMethod]
        public void CheckRecordTests()
        {
            FirstUniqueCharacterinaString obj = new FirstUniqueCharacterinaString();

            var x = obj.FirstUniqChar("leetcode");//0

            x = obj.FirstUniqChar("loveleetcode");//2

        }
    }
}