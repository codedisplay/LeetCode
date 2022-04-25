using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ContiguousArrayTests
    {
        [TestMethod]
        public void FindMaxLengthTests()
        {
            ContiguousArray obj = new ContiguousArray();

            int[] nums = { 1, 0, 1, 1, 0, 1, 1, 0 };

            var x = obj.FindMaxLength(nums);
            Assert.AreEqual(x,4);

        }
    }
}
