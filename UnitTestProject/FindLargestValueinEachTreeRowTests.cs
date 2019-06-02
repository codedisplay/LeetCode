using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindLargestValueinEachTreeRowTests
    {
        [TestMethod]
        public void LargestValuesTests()
        {
            FindLargestValueinEachTreeRow obj = new FindLargestValueinEachTreeRow();

            TreeNode node = new TreeNode(25) { left = new TreeNode(20) { }, right = new TreeNode(35) { } };

            var x = obj.LargestValues(node);//25

            node = new TreeNode(25)
            {
                left = new TreeNode(15)
                {
                    left = new TreeNode(10)
                    {
                        left = new TreeNode(5) { }
                    },
                    right = new TreeNode(18)
                    {
                        left = new TreeNode(17) { },
                        right = new TreeNode(20) { }
                    }
                },
                right = new TreeNode(40)
                {
                    left = new TreeNode(35) { },
                    right = new TreeNode(45)
                    {
                        left = new TreeNode(44) { },
                        right = new TreeNode(49) { }
                    }
                }
            };

            x = obj.LargestValues(node);//35

            node = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(5)
                    {
                  
                    },
                    right = new TreeNode(3)
                    {
                      
                    }
                },
                right = new TreeNode(2)
                {
                 
                    right = new TreeNode(9)
                    {
         
                    }
                }
            };

            x = obj.LargestValues(node);//35
        }
    }
}
