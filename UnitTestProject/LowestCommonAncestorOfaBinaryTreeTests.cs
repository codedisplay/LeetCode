using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LowestCommonAncestorOfaBinaryTreeTests
    {
        [TestMethod]
        public void LowestCommonAncestor()
        {
            LowestCommonAncestorOfaBinaryTree l = new LowestCommonAncestorOfaBinaryTree();

            TreeNode treeNode = new TreeNode(3)
            {
                left = new TreeNode(5){
                    left = new TreeNode(6) ,
                    right = new TreeNode(2) {
                        left = new TreeNode(7),
                        right = new TreeNode(4) }
            },
                right= new TreeNode(1)
            };

            Assert.AreEqual(3, l.LowestCommonAncestor(treeNode, new TreeNode(1),new TreeNode(5)).val);

            Assert.AreEqual(5, l.LowestCommonAncestor(treeNode, new TreeNode(6), new TreeNode(2)).val);

            Assert.AreEqual(2, l.LowestCommonAncestor(treeNode, new TreeNode(7), new TreeNode(2)).val);
            Assert.AreEqual(3, l.LowestCommonAncestor(treeNode, new TreeNode(7), new TreeNode(1)).val);
        }
    }
}
