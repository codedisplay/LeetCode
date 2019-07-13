using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PermutationsIITests
    {
        [TestMethod]
        public void PermuteUniqueTests()
        {
            PermutationsII obj = new PermutationsII();
            var arr = new int[] { 1, 2, 3 };
            var x = obj.PermuteUnique(arr);

            arr = new int[] { 1};
            x = obj.PermuteUnique(arr);

            arr = new int[] { };
            x = obj.PermuteUnique(arr);

            arr = new int[] { 1, 1, 2 };
            x = obj.PermuteUnique(arr);

            arr = new int[] { 1,1,2,3};
            x = obj.PermuteUnique(arr);
        }
    }
}
