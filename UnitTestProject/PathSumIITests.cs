using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PathSumIIITests
    {
        [TestMethod]
        public void PathSumTests()
        {
            PathSumIII obj = new PathSumIII();

            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                }
            };

            var x = obj.PathSum(node, 7);//2

            var i = Helpers.GenerateBinaryTree(new int?[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 });
            //Return 3.The paths that sum to 8 are:

            //1.  5-> 3
            //2.  5-> 2-> 1
            //3. - 3-> 11
            x = obj.PathSum(i, 8);//3

            node = new TreeNode(1)
            {
            };

            x = obj.PathSum(node, 0);//0
        }
    }
}
