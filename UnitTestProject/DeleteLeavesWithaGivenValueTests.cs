using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DeleteLeavesWithaGivenValueTests
    {
        [TestMethod]
        public void RemoveLeafNodesTests()
        {
            DeleteLeavesWithaGivenValue obj = new DeleteLeavesWithaGivenValue();

            TreeNode node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 2, null, 2, 4 });
            int target = 2;
            var x = obj.RemoveLeafNodes(node1, target);//[1,null,3,null,4]

            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 3, 3, 3, 2 });
            target = 3;
            x = obj.RemoveLeafNodes(node1, target);//[1,3,null,null,2]

            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 2, null, 2, null, 2 });
            target = 2;
            x = obj.RemoveLeafNodes(node1, target);//[1]

            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 1, 1 });
            target = 1;
            x = obj.RemoveLeafNodes(node1, target);//[]

            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3 });
            target = 1;
            x = obj.RemoveLeafNodes(node1, target);//[1,2,3]
        }

    }
}
