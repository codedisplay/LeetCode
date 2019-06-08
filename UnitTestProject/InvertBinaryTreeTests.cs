using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class InvertBinaryTreeTests
    {
        [TestMethod]
        public void InvertTreeTests()
        {
            InvertBinaryTree obj = new InvertBinaryTree();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(3)
                {
                }
            };

          var x= obj.InvertTree(node);//

            node = new TreeNode(4)
            {
                left = new TreeNode(9)
                {
                    left = new TreeNode(5)
                    {
                    },
                    right = new TreeNode(1)
                    {
                    }
                },
                right = new TreeNode(0)
                {
                }
            }; 

          x=  obj.InvertTree(node);//

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                
            };

            obj.InvertTree(node);//

            node = new TreeNode(0)
            {
                left = new TreeNode(0)
                {
                    left = new TreeNode(5)
                    {
                    },
                    right = new TreeNode(1)
                    {
                    }
                },
                right = new TreeNode(0)
                {
                }
            };

            x = obj.InvertTree(node);//


        }
    }
}
