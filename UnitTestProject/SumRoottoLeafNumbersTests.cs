using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SumRoottoLeafNumbersTests
    {
        [TestMethod]
        public void SumNumbersTests()
        {
            SumRoottoLeafNumbers obj = new SumRoottoLeafNumbers();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                },
                right = new TreeNode(3)
                {
                }
            };

          var x= obj.SumNumbers(node);//25

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

          x=  obj.SumNumbers(node);//1026

            node = new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                },
                
            };

           x= obj.SumNumbers(node);//12

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

            x = obj.SumNumbers(node);//6


        }
    }
}
