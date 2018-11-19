using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindAllDuplicatesInAnArrayTests
    {
        [TestMethod]
        public void FindDuplicatesTests()
        {
            FindAllDuplicatesInAnArray obj = new FindAllDuplicatesInAnArray();

            var input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var resp = obj.FindDuplicates(input);

            //        Output:
            //[2, 3]
        }
    }
}
