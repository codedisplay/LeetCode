using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod]
        public void RemoveDuplicatesTests()
        {
            RemoveDuplicatesFromSortedArray obj = new RemoveDuplicatesFromSortedArray();

            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 3 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0, 0 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 1, 1, 2 };
            len = obj.RemoveDuplicates(nums);
        }
    }
}
