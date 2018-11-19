using LeetCode;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class IncreasingOrderSearchTreeTests
    {
        [TestMethod]
        public void IncreasingBSTTests()
        {
            IncreasingOrderSearchTree obj = new IncreasingOrderSearchTree();

            int?[] arr = new int?[] { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 };
            var x = Helpers.GenerateBinaryTree(arr);
            var y = obj.IncreasingBST(x);

            arr = new int?[] { 1, 2, 3 };
            x = Helpers.GenerateBinaryTree(arr);
            obj.IncreasingBST(x);
        }
    }
}
