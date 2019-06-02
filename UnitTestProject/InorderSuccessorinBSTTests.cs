using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class InorderSuccessorinBSTTests
    {
        [TestMethod]
        public void InorderSuccessorTests()
        {
            InorderSuccessorinBST obj = new InorderSuccessorinBST();

            TreeNode node = new TreeNode(25) { left = new TreeNode(20) { }, right = new TreeNode(35) { } };

            var x = obj.InorderSuccessor(node, 20);//25

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

            x = obj.InorderSuccessor(node, 25);//35
        }
    }
}
