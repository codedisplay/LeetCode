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
            int[] nums1 = new int[] {1,2,3,4};
            int[] nums2 = new int[] { 5,6,7 };
            MedianofTwoSortedArrays obj = new MedianofTwoSortedArrays();

            var x = obj.FindMedianSortedArrays(nums1, nums2);//4


        }
    }
}
