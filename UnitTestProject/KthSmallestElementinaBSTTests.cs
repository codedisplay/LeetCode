using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class KthSmallestElementinaBSTTests
    {
        [TestMethod]
        public void KthSmallestTests()
        {
            KthSmallestElementinaBST obj = new KthSmallestElementinaBST();

            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(2)
                },
                right = new TreeNode(4)
                {
                }
            };

            var x = obj.KthSmallest(node, 1);//1

            node = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                    {
                    }
                },
                right = new TreeNode(6)
                {
                }
            };

            x = obj.KthSmallest(node, 3);//3
          

        }
    }
}
