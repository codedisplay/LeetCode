using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Leaf_SimilarTreesTests
    {
        [TestMethod]
        public void LeafSimilarTests()
        {
            Leaf_SimilarTrees obj = new Leaf_SimilarTrees();

            TreeNode node1 = new TreeNode(3)
            {
                left = new TreeNode(5) { left = new TreeNode(6), right = new TreeNode(2) { left = new TreeNode(7), right = new TreeNode(4) } },
                right = new TreeNode(1) { left = new TreeNode(9), right = new TreeNode(8) }
            };

            TreeNode node2 = new TreeNode(3)
            {
                left = new TreeNode(5) { left = new TreeNode(6), right = new TreeNode(7) },
                right = new TreeNode(1)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(2)
                    { left = new TreeNode(9), right = new TreeNode(8) }
                }
            };

            var x = obj.LeafSimilar(node1, node2);//t

        }
    }
}
