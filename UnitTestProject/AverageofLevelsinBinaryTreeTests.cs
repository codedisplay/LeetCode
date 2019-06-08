using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AverageofLevelsinBinaryTreeTests
    {
        [TestMethod]
        public void AverageOfLevelsTests()
        {
            AverageofLevelsinBinaryTree obj = new AverageofLevelsinBinaryTree();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(3)
                {
                }
            };

            var x = obj.AverageOfLevels(node);//

            node = Helpers.GenerateBinaryTree(new int?[] {3, 9, 20, 15, 7});

            x = obj.AverageOfLevels(node);//

        }
    }
}
