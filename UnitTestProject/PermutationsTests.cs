using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PermutationsTests
    {
        [TestMethod]
        public void PermuteTests()
        {
            Permutations obj = new Permutations();
            var arr = new int[] { 1, 2, 3 };
            var x = obj.Permute(arr);

            arr = new int[] { 1};
            x = obj.Permute(arr);

            arr = new int[] { };
            x = obj.Permute(arr);
        }
    }
}
