using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PathSumIITests
    {
        [TestMethod]
        public void LargestValuesTests()
        {
            PathSumII obj = new PathSumII();

            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7) { },
                        right = new TreeNode(2) { }
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13) { },
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(5) { },
                        right = new TreeNode(1) { }
                    }
                }

            };

            var x = obj.PathSum(node, 22);//

          var i=  Helpers.GenerateBinaryTree(new int?[] { 1, 2 });

             x = obj.PathSum(i, 1);//

             i = Helpers.GenerateBinaryTree(new int?[] { 1, -2,-3,1,3,-2,null,-1 });

            x = obj.PathSum(i, -1);//
        }
    }
}
