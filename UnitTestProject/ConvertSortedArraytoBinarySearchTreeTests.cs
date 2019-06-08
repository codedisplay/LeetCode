using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ConvertSortedArraytoBinarySearchTreeTests
    {
        [TestMethod]
        public void SortedArrayToBSTTests()
        {
            ConvertSortedArraytoBinarySearchTree obj = new ConvertSortedArraytoBinarySearchTree();

            var val = new int[] { -10, -3, 0, 5, 9 };

            var x = obj.SortedArrayToBST(val);//

            val = new int[] { -10, -3, 0, 5, 9, 15, 20 };

            x = obj.SortedArrayToBST(val);//

            val = new int[] { 1, 2, 3, 4, 5, 6, 7};

            x = obj.SortedArrayToBST(val);//
        }
    }
}
