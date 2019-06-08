using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SmallestSubtreewithalltheDeepestNodesTests
    {
        [TestMethod]
        public void SubtreeWithAllDeepestTests()
        {
            SmallestSubtreewithalltheDeepestNodes obj = new SmallestSubtreewithalltheDeepestNodes();

            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                    {
                    }
                }
            };

            var x = obj.SubtreeWithAllDeepest(node);


            node = new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    right = new TreeNode(2)
                    {
       
                    }
                },
 
            };

            x = obj.SubtreeWithAllDeepest(node);

            node = new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    right = new TreeNode(2)
                    {
        
                    }
                },
                right = new TreeNode(1)
                {
                    right = new TreeNode(8)
                    {
                    }
                }
            };


            x = obj.SubtreeWithAllDeepest(node);
        }

    }
}
