using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Model;

namespace UnitTestProject
{
    [TestClass]
    public class MergeTwoBinaryTreesTests
    {
        [TestMethod]
        public void MergeTreesTests()
        {
            MergeTwoBinaryTrees obj = new MergeTwoBinaryTrees();

            ////    [1,3,2,5]
            ////[2,1,3,null,4,null,7]

            TreeNode node1 = new TreeNode(1) { left = new TreeNode(3) { left = new TreeNode(5) }, right = new TreeNode(2) };

            TreeNode node2 = new TreeNode(2) { left = new TreeNode(1) { right = new TreeNode(4) }, right = new TreeNode(3) { right = new TreeNode(7) } };

            obj.MergeTrees(node1, node2);
        }
    }
}
