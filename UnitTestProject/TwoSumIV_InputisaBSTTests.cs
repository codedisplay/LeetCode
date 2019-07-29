using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TwoSumIV_InputisaBSTTests
    {
        [TestMethod]
        public void FindTargetTests()
        {
            TwoSumIV_InputisaBST obj = new TwoSumIV_InputisaBST();
            //    Input:
            //    5
            //   / \
            //  3   6
            // / \   \
            //2   4   7

            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                    },
                    right = new TreeNode(4)
                    {
                    }
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(7)
                    {
                    }
                }
            };
            var x = obj.FindTarget(node,9);//t

            x = obj.FindTarget(node, 28);//F
        }
    }
}
