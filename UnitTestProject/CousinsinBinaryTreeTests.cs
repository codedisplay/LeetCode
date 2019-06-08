using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CousinsinBinaryTreeTests
    {
        [TestMethod]
        public void IsCousinsTests()
        {
            CousinsinBinaryTree obj = new CousinsinBinaryTree();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                    {
                    }
                }
            };

            var x = obj.IsCousins(node,4,5);//true

            x = obj.IsCousins(node, 2, 5);//false

            x = obj.IsCousins(node, 2, 3);//false

        }

    }
}
