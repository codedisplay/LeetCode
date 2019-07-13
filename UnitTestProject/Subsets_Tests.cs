using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Subsets_Tests
    {
        [TestMethod]
        public void SubsetsTests()
        {
            Subsets_ obj = new Subsets_();

            var arr = new int[] { 1, 2, 3 };
            var x = obj.Subsets(arr);//8 count


        }
    }
}
