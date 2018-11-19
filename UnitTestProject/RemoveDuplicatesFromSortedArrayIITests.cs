using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayIITests
    {
        [TestMethod]
        public void RemoveDuplicatesTests()
        {
            RemoveDuplicatesFromSortedArrayII obj = new RemoveDuplicatesFromSortedArrayII();

            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            int len = obj.RemoveDuplicates(nums);

            nums = new int[] { 1, 1, 1 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 1, 2, 2 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 3, 1, 2, 2 };
            len =obj.RemoveDuplicates(nums);

            nums = new int[] { 1, 1, 2, 2 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 3 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 0, 0 };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { };
            len = obj.RemoveDuplicates(nums);

            nums = new int[] { 1, 1, 1, 2 };
            len = obj.RemoveDuplicates(nums);
        }
    }
}
