using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ReverseWordsinaStringTests
    {
        [TestMethod]
        public void ReverseWordsTests()
        {
            ReverseWordsinaString obj = new ReverseWordsinaString();

            var x = obj.ReverseWords(" the    sky  is  blue ");

            x = obj.ReverseWords(" hello world! ");

            x = obj.ReverseWords("  ");

            x = obj.ReverseWords("asf  ");
        }
    }
}