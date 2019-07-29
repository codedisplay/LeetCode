using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BinaryTreeLongestConsecutiveSequenceIITests
    {
        [TestMethod]
        public void LongestConsecutiveTests()
        {
            BinaryTreeLongestConsecutiveSequenceII obj = new BinaryTreeLongestConsecutiveSequenceII();
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
            var x = obj.LongestConsecutive(node);//4

            //  2
            //   \
            //    3
            //   /
            //  2
            // /
            //1
            obj = new BinaryTreeLongestConsecutiveSequenceII();
            node = new TreeNode(2)
            {
                right = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1)
                    },

                }
            };
            x = obj.LongestConsecutive(node);//3

            obj = new BinaryTreeLongestConsecutiveSequenceII();
            x = obj.LongestConsecutive(Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5 }));//2

            obj = new BinaryTreeLongestConsecutiveSequenceII();
            x = obj.LongestConsecutive(Helpers.GenerateBinaryTree(new int?[] { 1, 3, 2, 4, null, null, 5 }));//2

            obj = new BinaryTreeLongestConsecutiveSequenceII();
            node = new TreeNode(3)
            {
                right = new TreeNode(4)
                {
                    right = new TreeNode(5)
                    {
                        left = new TreeNode(4)
                        {
                        },
                        right = new TreeNode(6)
                        {
                            right = new TreeNode(7)
                        }
                    }
                }
            };
            x = obj.LongestConsecutive(node);//5

            obj = new BinaryTreeLongestConsecutiveSequenceII();
            var tree = Helpers.GenerateBinaryTree(new int?[] { 24, 25, 25, 26, 24, 26, 24, 25, 27, 23, 23, 25, 25, 23, 23, 26, 24, 26, 28, 24, 22, 22, 24, 26, 26, 26, 26, 22, 24, 22, 22, null, 27, null, 25, null, 25, null, 27, null, 25, null, 21, null, 23, 23, 23, null, 25, null, 25, null, 27, 27, 25, null, 23, null, 23, null, 21, 21, 21});
            x = obj.LongestConsecutive(tree);//8
        }

    }
}
