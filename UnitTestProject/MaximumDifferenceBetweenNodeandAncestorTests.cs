using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MaximumDifferenceBetweenNodeandAncestorTests
    {
        [TestMethod]
        public void MaxAncestorDiffTests()
        {
            MaximumDifferenceBetweenNodeandAncestor obj = new MaximumDifferenceBetweenNodeandAncestor();

            TreeNode node1 = Helpers.GenerateBinaryTree(new int?[] { 1, null, 2, null, 0, 3 });
            var x = obj.MaxAncestorDiff(node1);//




    }

    }
}
