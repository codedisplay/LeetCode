using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindUnsortedSubarrayTests
    {
        [TestMethod]
        public void FindUnsortedSubarrayTest()
        {
            ShortestUnsortedContinuousSubarray l = new ShortestUnsortedContinuousSubarray();

            int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            Assert.AreEqual(5, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 3, 4, 1, 5, 6, 7 };
            Assert.AreEqual(4, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 2, 4, 8, 10, 9, 15 };
            Assert.AreEqual(2, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 2, 6, 4, 8, 10, 9, 15 };
            Assert.AreEqual(5, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 2, 3, 4, 8, 10, 10 };
            Assert.AreEqual(0, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 8, 3, 4, 8, 10, 10 };
            Assert.AreEqual(3, l.FindUnsortedSubarray(nums));

            nums = new int[] { };
            Assert.AreEqual(0, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 1 };
            Assert.AreEqual(2, l.FindUnsortedSubarray(nums));

            nums = new int[] { 2, 1, 1, 2 };
            Assert.AreEqual(3, l.FindUnsortedSubarray(nums));
        }
    }
}
