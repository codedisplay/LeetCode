using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CheckCompletenessofaBinaryTreeTests
    {
        [TestMethod]
        public void IsCompleteTreeTests()
        {
            CheckCompletenessofaBinaryTree obj = new CheckCompletenessofaBinaryTree();

            TreeNode node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6 });

            Assert.IsTrue(obj.IsCompleteTree(node));

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4, 5, null, 7 });

            Assert.IsFalse(obj.IsCompleteTree(node));

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 5, null, 7, 8 });

            Assert.IsFalse(obj.IsCompleteTree(node));

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 5, 6, 7, 8 });

            Assert.IsTrue(obj.IsCompleteTree(node));


        }
    }
}
