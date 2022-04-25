using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AllElementsinTwoBinarySearchTreesTests
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            AllElementsinTwoBinarySearchTrees obj = new AllElementsinTwoBinarySearchTrees();

            TreeNode node1 = Helpers.GenerateBinaryTree(new int?[] { 0, 3, 1, null, null, null, 2 });
            TreeNode node2 = Helpers.GenerateBinaryTree(new int?[] { 0, 3, 1, 2 });
            var x = obj.GetAllElements(node1, node2);


            node1 = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 });
            node2 = Helpers.GenerateBinaryTree(new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 });
            x = obj.GetAllElements(node1, node2);

            node1 = Helpers.GenerateBinaryTree(new int?[] { 2, 1, 4 });
            node2 = Helpers.GenerateBinaryTree(new int?[] { 1, 0, 3 });
            x = obj.GetAllElements(node1, node2);//0,1,1,2,3,4

            node1 = Helpers.GenerateBinaryTree(new int?[] { 0, -10, 10 });
            node2 = Helpers.GenerateBinaryTree(new int?[] { 5, 1, 7, 0, 2 });
            x = obj.GetAllElements(node1, node2);//-10,0,0,1,2,5,7,10

            node1 = Helpers.GenerateBinaryTree(new int?[] { });
            node2 = Helpers.GenerateBinaryTree(new int?[] { 5, 1, 7, 0, 2 });
            x = obj.GetAllElements(node1, node2);//0,1,2,5,7

            node1 = Helpers.GenerateBinaryTree(new int?[] { 0, -10, 10 });
            node2 = Helpers.GenerateBinaryTree(new int?[] { });
            x = obj.GetAllElements(node1, node2);//-10,0,10
        }


    }
}
