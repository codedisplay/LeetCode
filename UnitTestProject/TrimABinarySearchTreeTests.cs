using LeetCode;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TrimABinarySearchTreeTests
    {
        [TestMethod]
        public void TrimBSTTests()
        {
            TrimABinarySearchTree obj = new TrimABinarySearchTree();

            var arr = new int?[] { 1, 2, 3 };
            var node = Helpers.GenerateBinaryTree(arr);

            var x = obj.TrimBST(node, 1, 3);//[3,2,null,1]
        }
    }
}
