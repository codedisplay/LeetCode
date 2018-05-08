using LeetCode;
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

            ValidateBinarySearchTree.TreeNode t = new ValidateBinarySearchTree.TreeNode(1);

            t.left = new ValidateBinarySearchTree.TreeNode(1);

            Assert.IsFalse(fd.IsValidBST(t));//false

            t = new ValidateBinarySearchTree.TreeNode(10);

            t.left = new ValidateBinarySearchTree.TreeNode(5);

            t.right = new ValidateBinarySearchTree.TreeNode(15)
            {
                left = new ValidateBinarySearchTree.TreeNode(6),
                right = new ValidateBinarySearchTree.TreeNode(20)
            };

            Assert.IsFalse(fd.IsValidBST(t));//false

            t = new ValidateBinarySearchTree.TreeNode(3);

            t.left = new ValidateBinarySearchTree.TreeNode(1)
            {
                left = new ValidateBinarySearchTree.TreeNode(0),
                right = new ValidateBinarySearchTree.TreeNode(2)
            };

            t.right = new ValidateBinarySearchTree.TreeNode(5)
            {
                left = new ValidateBinarySearchTree.TreeNode(4),
                right = new ValidateBinarySearchTree.TreeNode(6)
            };

            Assert.IsTrue(fd.IsValidBST(t));//true
        }
    }
}
