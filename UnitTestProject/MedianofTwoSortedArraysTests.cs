using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MedianofTwoSortedArraysTests
    {
        [TestMethod]
        public void ThreeSumClosestTests()
        {
            int[] nums = new int[] { -4, -1, 1, 2 };
            MedianofTwoSortedArrays obj = new MedianofTwoSortedArrays();

            var x = obj.ThreeSumClosest(nums, 1);//2


        }
    }
}
