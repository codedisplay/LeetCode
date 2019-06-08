using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FlipEquivalentBinaryTreesTests
    {
        [TestMethod]
        public void FlipEquivTests()
        {
            FlipEquivalentBinaryTrees obj = new FlipEquivalentBinaryTrees();

            TreeNode node1 = Helpers.GenerateBinaryTree(new int?[] { 0, 3, 1, null, null, null, 2 });
            TreeNode node2 = Helpers.GenerateBinaryTree(new int?[] { 0, 3, 1, 2 });
            var x = obj.FlipEquiv(node1, node2);//false


            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 });
            node2 = Helpers.GenerateBinaryTree(new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 });
            x = obj.FlipEquiv(node1, node2);//true


        }

    }
}
