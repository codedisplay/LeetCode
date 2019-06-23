using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindFirstandLastPositionofElementinSortedArrayTests
    {
        [TestMethod]
        public void SearchRangeTests()
        {
            FindFirstandLastPositionofElementinSortedArray obj = new FindFirstandLastPositionofElementinSortedArray();

            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var x = obj.SearchRange(nums, 8);
            Assert.AreEqual(x, new int[] { 3, 4 });

            nums = new int[] { 5, 7, 7, 8, 8, 10 };
            Assert.AreEqual(obj.SearchRange(nums, 6), new int[] { -1, -1 });

            nums = new int[] { 5, 7, 7, 8, 8, 10 };
             x = obj.SearchRange(nums, 6);
            Assert.AreEqual(x, new int[] { -1, -1 });

        }

    }
}
