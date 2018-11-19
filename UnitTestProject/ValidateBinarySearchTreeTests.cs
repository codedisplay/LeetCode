using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ValidateBinarySearchTreeTests
    {
        [TestMethod]
        public void IsValidBSTTest()
        {
            ValidateBinarySearchTree fd = new ValidateBinarySearchTree();

            TreeNode t = new TreeNode(1);

            t.left = new TreeNode(1);

            Assert.IsFalse(fd.IsValidBST(t));//false

            t = new TreeNode(10);

            t.left = new TreeNode(5);

            t.right = new TreeNode(15)
            {
                left = new TreeNode(6),
                right = new TreeNode(20)
            };

            Assert.IsFalse(fd.IsValidBST(t));//false

            t = new TreeNode(3);

            t.left = new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(2)
            };

            t.right = new TreeNode(5)
            {
                left = new TreeNode(4),
                right = new TreeNode(6)
            };

            Assert.IsTrue(fd.IsValidBST(t));//true
        }
    }
}
