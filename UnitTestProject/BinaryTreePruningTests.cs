using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BinaryTreePruningTests
    {
        [TestMethod]
        public void PruneTreeTests()
        {
            BinaryTreePruning obj = new BinaryTreePruning();

            TreeNode node = new TreeNode(1)
            {
    
                right = new TreeNode(0)
                {
                    left=new TreeNode(0),
                    right = new TreeNode(1)
                    {
                    }
                }
            };

            var x = obj.PruneTree(node);

            node = new TreeNode(1)
            {
                left = new TreeNode(0)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(0)
                    {
                    }
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                    {
                    }
                }
            };


            x = obj.PruneTree(node);

        }

    }
}
