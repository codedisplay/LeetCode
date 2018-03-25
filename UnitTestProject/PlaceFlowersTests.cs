using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PlaceFlowersTests
    {
        [TestMethod]
        public void CanPlaceFlowersTests()
        {
            PlaceFlowers l = new PlaceFlowers();

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
