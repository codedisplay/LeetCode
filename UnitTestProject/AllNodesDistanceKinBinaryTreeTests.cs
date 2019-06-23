using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AllNodesDistanceKinBinaryTreeTests
    {
        [TestMethod]
        public void DistanceKTests()
        {
            AllNodesDistanceKinBinaryTree obj = new AllNodesDistanceKinBinaryTree();


            // node = new TreeNode(1)
            //{
            //    left = new TreeNode(2)
            //    {
            //    },
            //    right = new TreeNode(3)
            //    {
            //    }
            //};

            //var x = obj.AverageOfLevels(node);//

            TreeNode node = Helpers.GenerateBinaryTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
            TreeNode target = new TreeNode(5);
            var x = obj.DistanceK(node, target, 2);//7,4,1

            target = new TreeNode(5);
            x = obj.DistanceK(node, target, 0);

            target = new TreeNode(3);
            x = obj.DistanceK(node, target, 0);

            node = Helpers.GenerateBinaryTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, 9, null, 7, 4 });
            target = new TreeNode(5);
            x = obj.DistanceK(node, target, 2);//9,7,4,1

            target = new TreeNode(1);
            x = obj.DistanceK(node, target, 3);//6,2

            node = Helpers.GenerateBinaryTree(new int?[] { 0, 1, null, 3, 2 });
            target = new TreeNode(2);
            x = obj.DistanceK(node, target, 1);//[1]
        }
    }
}
