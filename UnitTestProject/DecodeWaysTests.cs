using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DecodeWaysTests
    {
        [TestMethod]
        public void NumDecodingsTests()
        {
            DecodeWays obj = new DecodeWays();

            var s = "12";
            var x = obj.NumDecodings(s);//2

             s = "226";
             x = obj.NumDecodings(s);//3

            s = "121";
            x = obj.NumDecodings(s);//3

            s = "1234";
            x = obj.NumDecodings(s);//3

            s = "100";
            x = obj.NumDecodings(s);//0

            s = "30";
            x = obj.NumDecodings(s);//0

            s = "29";
            x = obj.NumDecodings(s);//1

            s = "309";
            x = obj.NumDecodings(s);//0

            s = "10";
            x = obj.NumDecodings(s);//1

            s = "1001";
            x = obj.NumDecodings(s);//0

            s = "110";
            x = obj.NumDecodings(s);//0

        }
    }
}
