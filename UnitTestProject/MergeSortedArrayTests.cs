using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MergeSortedArrayTests
    {
        [TestMethod]
        public void MergeTests()
        {
            MergeSortedArray obj = new MergeSortedArray();

            var arr = new int[] { 1, 2, 3, 0, 0, 0 };
            var arr1 = new int[] { 2, 5, 6 };
            obj.Merge(arr, 3, arr1, 3);//[1,2,2,3,5,6]

            arr = new int[] { 0 };
            arr1 = new int[] { 1 };
            obj.Merge(arr, 0, arr1, 1);//[1,2,2,3,5,6]

            arr = new int[] { };
            arr1 = new int[] { };
            obj.Merge(arr, 0, arr1, 0);

            arr = new int[] { 1, 2, 3 };
            arr1 = new int[] { };
            obj.Merge(arr, 0, arr1, 0);
        }
    }
}
