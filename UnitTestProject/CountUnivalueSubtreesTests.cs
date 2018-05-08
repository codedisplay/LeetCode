using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode.CountUnivalueSubtrees;

namespace UnitTestProject
{
    [TestClass]
    public class CountUnivalueSubtreesTests
    {
        [TestMethod]
        public void CountUnivalSubtrees()
        {
            CountUnivalueSubtrees l = new CountUnivalueSubtrees();

            TreeNode treeNode =
                new TreeNode(5)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(5) { },
                        right = new TreeNode(5) { }
                    },
                    right = new TreeNode(5)
                    {
                        right = new TreeNode(5) { }
                    }
                };

            Assert.AreEqual(4, l.CountUnivalSubtrees(treeNode));
        }
    }
}
