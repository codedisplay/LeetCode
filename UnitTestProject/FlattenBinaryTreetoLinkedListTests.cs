using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FlattenBinaryTreetoLinkedListTests
    {
        [TestMethod]
        public void FlattenTests()
        {
            FlattenBinaryTreetoLinkedList obj = new FlattenBinaryTreetoLinkedList();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(3)
                {
                }
            };

            obj.Flatten(node);//

            node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                    },
                    right = new TreeNode(4)
                    {
                    }
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(6)
                    {
                    }
                }
            }; 

            obj.Flatten(node);//

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                
            };

          obj.Flatten(node);//

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                right = new TreeNode(20)
                {
                    left = new TreeNode(15)
                    {
                    },
                    right = new TreeNode(7)
                    {
                    }
                }
            };

            obj.Flatten(node);//


        }
    }
}
