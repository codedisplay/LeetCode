using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RangeSumofBSTTests
    {
        [TestMethod]
        public void RangeSumBSTTests()
        {
            RangeSumofBST obj = new RangeSumofBST();

            TreeNode node = Helpers.GenerateBinaryTree(new int?[] { 10, 5, 15, 3, 7, null, 18 });
            var x = obj.RangeSumBST(node, 7, 15);//32

            node = Helpers.GenerateBinaryTree(new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 });
            x = obj.RangeSumBST(node, 6, 10);//23

            node = Helpers.GenerateBinaryTree(new int?[] { 18, 9, 27, 6, 15, 24, 30, 3, null, 12, null, 21 });
            x = obj.RangeSumBST(node, 18, 24);//63
        }

    }
}
