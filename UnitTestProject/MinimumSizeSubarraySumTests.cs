using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumSizeSubarraySumTests
    {
        [TestMethod]
        public void MinSubArrayLenTests()
        {
            MinimumSizeSubarraySum obj = new MinimumSizeSubarraySum();

            var nums = new int[] { 2, 3, 1, 2, 4, 3 };
            var x = obj.MinSubArrayLen(7, nums);//2

        }
    }
}
