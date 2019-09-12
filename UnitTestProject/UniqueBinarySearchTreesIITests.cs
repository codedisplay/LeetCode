using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UniqueBinarySearchTreesIITest
    {
        [TestMethod]
        public void SearchTest()
        {
            UniqueBinarySearchTreesII l = new UniqueBinarySearchTreesII();


            var x = l.GenerateTrees(3);

            x = l.GenerateTrees(2);

            x = l.GenerateTrees(1);

            x = l.GenerateTrees(5);

        }
    }
}
