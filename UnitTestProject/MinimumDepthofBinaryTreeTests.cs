using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumDepthofBinaryTreeTests
    {
        [TestMethod]
        public void MinDepthTests()
        {
            MinimumDepthofBinaryTree obj = new MinimumDepthofBinaryTree();

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

            var x = obj.MinDepth(node);//2

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                
            };

            x = obj.MinDepth(node);//2


        }
    }
}
