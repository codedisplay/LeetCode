using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumDistanceBetweenBSTNodesTests
    {
        [TestMethod]
        public void MinDiffInBSTTests()
        {
            MinimumDistanceBetweenBSTNodes obj = new MinimumDistanceBetweenBSTNodes();

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

            var x = obj.MinDiffInBST(node);//1

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

            x = obj.MinDiffInBST(node);//1

            node = new TreeNode(1)
            {
                right = new TreeNode(3)
                {
                    left=new TreeNode(2)
                }
            };

            x = obj.MinDiffInBST(node);//1

            node = new TreeNode(1)
            {
                right = new TreeNode(300)
                {
                    left = new TreeNode(20)
                }
            };

            x = obj.MinDiffInBST(node);//19


        }
    }
}
