using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SearchInRotatedSortedArrayTest
    {
        [TestMethod]
        public void SearchTest()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            SearchInRotatedSortedArray l = new SearchInRotatedSortedArray();

            Assert.AreEqual(2, l.Search(arr, 6));

            Assert.AreEqual(-1, l.Search(arr, 40));

            Assert.AreEqual(6, l.Search(arr, 2));

            Assert.AreEqual(4, l.Search(arr, 0));

            Assert.AreEqual(0, l.Search(arr, 4));

            Assert.AreEqual(-1, l.Search(new int[] { }, 5));

            Assert.AreEqual(-1, l.Search(new int[] { 1 }, 0));

            Assert.AreEqual(-1, l.Search(new int[] { 1, 2 }, 0));

            Assert.AreEqual(-1, l.Search(new int[] { 1, 2, 3 }, 0));

            Assert.AreEqual(0, l.Search(new int[] { 1, 3 }, 1));

            Assert.AreEqual(1, l.Search(new int[] { 3, 1 }, 1));

            //var x = l.FindPivotInSortedArray(new int[] { 1, 3, 5 });

            //x = l.FindPivotInSortedArray(new int[] { 3, 5, 1 });

            //x = l.FindPivotInSortedArray(new int[] { 5, 1, 3 });

            //x = l.FindPivotInSortedArray(new int[] { 1, 2, 3, 4 });

            //x = l.FindPivotInSortedArray(new int[] { 2, 3, 4, 1 });

            //x = l.FindPivotInSortedArray(new int[] { 3, 4, 1, 2 });
        }
    }
}
