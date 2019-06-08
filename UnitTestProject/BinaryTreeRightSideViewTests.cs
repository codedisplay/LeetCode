using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BinaryTreeRightSideViewTests
    {
        [TestMethod]
        public void RightSideViewTests()
        {
            BinaryTreeRightSideView obj = new BinaryTreeRightSideView();

            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                right = new TreeNode(20)
                {
                    left = new TreeNode(15)
                    {
                    },
                    right = new TreeNode(7)
                    {
                    }
                }
            };

            var x = obj.RightSideView(node);//

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                
            };

            x = obj.RightSideView(node);//

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, null, 5, null, 4 });

            x = obj.RightSideView(node);//[1, 3, 4]
        }
    }
}
