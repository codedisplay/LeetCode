using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LongestUnivaluePathTests
    {
        [TestMethod]
        public void LongestUniValuePathTests()
        {
            LongestUniValuePath obj = new LongestUniValuePath();

            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(1)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(5)
                }
            };

            var x = obj.LongestUnivaluePath(node);//2

             node = new TreeNode(1)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(5)
                }
            };

            x = obj.LongestUnivaluePath(node);//2

            node = new TreeNode(1)
            {
            };

            x = obj.LongestUnivaluePath(node);//0

            node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {

                    },
                    right = new TreeNode(5)
                    {

                    }
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(7)
                    {

                    }
                }
            };

            x = obj.LongestUnivaluePath(node);//0
        }
    }
}
