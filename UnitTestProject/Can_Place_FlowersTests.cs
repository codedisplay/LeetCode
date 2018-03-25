using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Can_Place_FlowersTests
    {
        [TestMethod]
        public void CanPlaceFlowersTests()
        {
            Can_Place_Flowers l = new Can_Place_Flowers();

            int[] nums = { 1, 0, 0, 0, 1 };
            int n = 1;
            Assert.IsTrue(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 0, 0, 0, 1 };
            n = 2;
            Assert.IsFalse(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 1, 0, 0, 0, 0, 0, 1 };
            n = 2;
            Assert.IsFalse(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 0, 0, 0, 0, 1 };
            n = 2;
            Assert.IsFalse(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 0, 1, 0, 1, 0, 1 };
            n = 0;
            Assert.IsTrue(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 0, 1, 0, 1, 0, 1, 0, 0 };
            n = 1;
            Assert.IsTrue(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 0, 0 };
            n = 1;
            Assert.IsTrue(l.CanPlaceFlowers(nums, n));

            nums = new int[] { 1, 0, 0, 1, 0, 1, 0, 0 };
            n = 1;
            Assert.IsTrue(l.CanPlaceFlowers(nums, n));


        }
    }
}
