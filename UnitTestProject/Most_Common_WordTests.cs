using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Most_Common_WordTests
    {
        [TestMethod]
        public void MostCommonWordTests()
        {
            Most_Common_Word obj = new Most_Common_Word();

            string num1 = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = new string[] { "hit" };
            var x = obj.MostCommonWord(num1, banned);//"ball"

            num1 = "a, a, a, a, b,b,b,c, c";
            banned = new string[] { "a" };
            x = obj.MostCommonWord(num1, banned);//"b"
        }
    }
}
