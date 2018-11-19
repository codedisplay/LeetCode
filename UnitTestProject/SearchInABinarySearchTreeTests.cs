using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Model;

namespace UnitTestProject
{
    [TestClass]
    public class SearchInABinarySearchTreeTests
    {
        [TestMethod]
        public void SearchBSTTests()
        {
            SearchInABinarySearchTree obj = new SearchInABinarySearchTree();

            TreeNode node = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
            };

            var x = obj.SearchBST(node, 2);

            //            [18,2,22,null,null,null,63,null,84,null,null]
            //
            node = new TreeNode(18)
            {
                left = new TreeNode(2),
                right = new TreeNode(22)
                {

                    right = new TreeNode(63) { right = new TreeNode(84) }
                }
            };

            x = obj.SearchBST(node, 63);

        }
    }
}
