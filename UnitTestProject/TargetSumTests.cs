using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TargetSumTests
    {
        [TestMethod]
        public void FindTargetSumWaysTests()
        {
            TargetSum obj = new TargetSum();

            var str = new int[] { 1, 1, 1, 1, 1 };
            var x = obj.FindTargetSumWays(str, 3);//5

            str = new int[] { 1, 1, 1, 1, 1, 1 };
            x = obj.FindTargetSumWays(str, 4);//6


        }
    }
}
