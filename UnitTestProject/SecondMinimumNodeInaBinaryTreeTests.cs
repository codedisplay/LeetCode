using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SecondMinimumNodeInaBinaryTreeTests
    {
        [TestMethod]
        public void FindSecondMinimumValueTests()
        {
            SecondMinimumNodeInaBinaryTree obj = new SecondMinimumNodeInaBinaryTree();

            TreeNode node = new TreeNode(2)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(5)
                {
                    left = new TreeNode(5)
                    {
                    },
                    right = new TreeNode(7)
                    {
                    }
                }
            };

            var x = obj.FindSecondMinimumValue(node);//5

            node = new TreeNode(2)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(2)
                {
                }
            };

            x = obj.FindSecondMinimumValue(node);//-1

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 1, 3, 1, 1, 3, 4, 3, 1, 1, 1, 3, 8, 4, 8, 3, 3, 1, 6, 2, 1 });
            x = obj.FindSecondMinimumValue(node);//2

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 1, 3, 1, 2});
            x = obj.FindSecondMinimumValue(node);//2
        }

    }
}
