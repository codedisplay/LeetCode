using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindTheDuplicateNumberTests
    {
        [TestMethod]
        public void FindDuplicateTests()
        {
            FindTheDuplicateNumber obj = new FindTheDuplicateNumber();

            // TODO:solution
            var input = new int[] { 1, 3, 4, 2, 2 };
            var resp = obj.FindDuplicate(input);

            input = new int[] { 3, 1, 3, 4, 2 };
            resp = obj.FindDuplicate(input);

            input = new int[] { 3, 1, 4, 4, 2 };
            resp = obj.FindDuplicate(input);

            input = new int[] { 2, 2, 2, 2, 2 };
            resp = obj.FindDuplicate(input);
        }
    }
}
