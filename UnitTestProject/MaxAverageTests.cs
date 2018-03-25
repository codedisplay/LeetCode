using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MaxAverageTests
    {
        [TestMethod]
        public void FindMaxAverageTest()
        {
            MaxAverage l = new MaxAverage();

            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            Assert.AreEqual(12.75, l.FindMaxAverage(nums, k));

            nums = new int[] { 5, 34, 2 };
            k = 1;
            Assert.AreEqual(34, l.FindMaxAverage(nums, k));

            nums = new int[] { 0, 1, 1, 3, 3 };
            k = 4;
            Assert.AreEqual(2.0, l.FindMaxAverage(nums, k));

        }
    }
}
