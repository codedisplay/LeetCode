using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BinaryTreeLongestConsecutiveSequenceTests
    {
        [TestMethod]
        public void FindTargetTests()
        {
            BinaryTreeLongestConsecutiveSequence obj = new BinaryTreeLongestConsecutiveSequence();
            //    Input:
            //1
            // \
            //  3
            // / \
            //2   4
            //     \
            //      5

            TreeNode node = new TreeNode(1)
            {
                right = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                    },
                    right = new TreeNode(4)
                    {
                        right = new TreeNode(5)
                    }
                }
            };
            var x = obj.LongestConsecutive(node);//3

            //  2
            //   \
            //    3
            //   /
            //  2
            // /
            //1
            node = new TreeNode(2)
            {
                right = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left= new TreeNode(1)
                    },
                   
                }
            };
            x = obj.LongestConsecutive(node);//2

            x = obj.LongestConsecutive(Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5}));//2
        }
    }
}
