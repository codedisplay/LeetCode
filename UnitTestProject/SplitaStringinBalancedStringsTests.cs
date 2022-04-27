using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SplitaStringinBalancedStringsTests
    {
        [TestMethod]
        public void BalancedStringSplitTests()
        {
            SplitaStringinBalancedStrings obj = new SplitaStringinBalancedStrings();

            string s = "RLRRLLRLRL";
            var x = obj.BalancedStringSplit(s);//4

            s = "RLLLLRRRLR";
            x = obj.BalancedStringSplit(s);//3

            s = "LLLLRRRR";
            x = obj.BalancedStringSplit(s);//1

            s = "RLRRRLLRLL";
            x = obj.BalancedStringSplit(s);//2
        }
    }
}
