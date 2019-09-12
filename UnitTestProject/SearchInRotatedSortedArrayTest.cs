using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SearchInRotatedSortedArrayIITest
    {
        [TestMethod]
        public void SearchTest()
        {
            int[] arr = new int[] { 4, 5, 5, 5, 6, 7, 0, 0, 1, 2, 2 };
            SearchInRotatedSortedArrayII l = new SearchInRotatedSortedArrayII();

            Assert.AreEqual(true, l.Search(arr, 6));

            Assert.AreEqual(false, l.Search(arr, 40));

            Assert.AreEqual(true, l.Search(arr, 2));

            Assert.AreEqual(true, l.Search(arr, 0));

            Assert.AreEqual(true, l.Search(arr, 4));

            Assert.AreEqual(false, l.Search(new int[] { }, 5));

            Assert.AreEqual(false, l.Search(new int[] { 1 }, 0));

            Assert.AreEqual(false, l.Search(new int[] { 1, 2 }, 0));

            Assert.AreEqual(false, l.Search(new int[] { 1, 2, 3 }, 0));

            Assert.AreEqual(true, l.Search(new int[] { 1, 3 }, 1));

            Assert.AreEqual(true, l.Search(new int[] { 3, 1 }, 1));

            Assert.AreEqual(true, l.Search(new int[] { 1, 3, 1, 1, 1 }, 3));

            Assert.AreEqual(true, l.Search(new int[] { 1, 1, 3, 1 }, 3));

            Assert.AreEqual(true, l.Search(new int[] { 1, 1, 3 }, 3));

            Assert.AreEqual(true, l.Search(new int[] { 3, 1, 1 }, 3));

            Assert.AreEqual(true, l.Search(new int[] { 3, 1, 1, 1, 1, 1, 1, 1, 1 }, 3));

            Assert.AreEqual(true, l.Search(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 3 }, 3));

    
        }
    }
}
