using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MaximumProductOfThreeNumbersTests
    {
        [TestMethod]
        public void MaximumProductTest()
        {
            MaximumProductOfThreeNumbers l = new MaximumProductOfThreeNumbers();

            int[] nums = { 1, 2, 3 };
            Assert.AreEqual(6, l.MaximumProduct(nums));

            nums = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(24, l.MaximumProduct(nums));

            nums = new int[] { -10, -4, -1, 1, 2, 3, 4 };
            Assert.AreEqual(160, l.MaximumProduct(nums));
        }
    }
}
