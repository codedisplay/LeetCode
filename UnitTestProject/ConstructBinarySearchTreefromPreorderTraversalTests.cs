using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ConstructBinarySearchTreefromPreorderTraversalTests
    {
        [TestMethod]
        public void BstFromPreorderTests()
        {
            ConstructBinarySearchTreefromPreorderTraversal obj = new ConstructBinarySearchTreefromPreorderTraversal();

            var values = new int[] { 8, 5, 1, 7, 10, 12 };
            var x = obj.BstFromPreorder(values);


        }

    }
}
