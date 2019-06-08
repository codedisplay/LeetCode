using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BinaryTreeLevelOrderTraversal_IITests
    {
        [TestMethod]
        public void LevelOrderBottomTests()
        {
            BinaryTreeLevelOrderTraversal_II obj = new BinaryTreeLevelOrderTraversal_II();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(3)
                {
                }
            };

            var x = obj.LevelOrderBottom(node);//

            node = Helpers.GenerateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7});

            x = obj.LevelOrderBottom(node);//

        }
    }
}
