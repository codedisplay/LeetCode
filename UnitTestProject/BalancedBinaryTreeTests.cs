using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BalancedBinaryTreeTests
    {
        [TestMethod]
        public void IsBalancedTests()
        {
            BalancedBinaryTree obj = new BalancedBinaryTree();

            var t = new TreeNode(3) { left = new TreeNode(9), right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) } };

            var x = obj.IsBalanced(t);

            t = new TreeNode(1) { left = new TreeNode(2) { left = new TreeNode(3) { left = new TreeNode(4), right = new TreeNode(4) }, right = new TreeNode(3) }, right = new TreeNode(2) };

            x = obj.IsBalanced(t);

        }
    }
}
