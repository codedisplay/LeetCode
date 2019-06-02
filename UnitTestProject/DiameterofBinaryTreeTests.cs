using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DiameterofBinaryTreeTests
    {
        [TestMethod]
        public void DiameterOfBinaryTreeTests()
        {
            DiameterofBinaryTree obj = new DiameterofBinaryTree();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                }
            };

            var x = obj.DiameterOfBinaryTree(node);//

         

            node = new TreeNode(1)
            {
            };

            x = obj.DiameterOfBinaryTree(node);//

            node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {

                    },
                    right = new TreeNode(5)
                    {

                    }
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(7)
                    {

                    }
                }
            };

            x = obj.DiameterOfBinaryTree(node);
        }
    }
}
