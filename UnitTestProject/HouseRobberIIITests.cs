using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class HouseRobberIIITests
    {
        [TestMethod]
        public void RobTests()
        {
            HouseRobberIII obj = new HouseRobberIII();

            TreeNode node1 = Helpers.GenerateBinaryTree(new int?[] { 3, 2, 3, null, 3, null, 1 });
            var x = obj.Rob(node1);//7

            node1 = Helpers.GenerateBinaryTree(new int?[] { 3, 4, 5, 1, 3, null, 1 });
            x = obj.Rob(node1);//9

            node1 = Helpers.GenerateBinaryTree(new int?[] { 4, 1, null, 2, null, 3 });
            x = obj.Rob(node1);//7
    }

    }
}
