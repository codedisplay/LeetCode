using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumTimeDifferenceTests
    {
        [TestMethod]
        public void FindMinDifferenceTests()
        {
            MinimumTimeDifference obj = new MinimumTimeDifference();

            var arr = new string[] { "23:59", "00:00" };
            var x = obj.FindMinDifference(arr);//1

          
        }
    }
}
