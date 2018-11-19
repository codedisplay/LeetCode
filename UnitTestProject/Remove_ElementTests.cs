using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Remove_ElementTests
    {
        [TestMethod]
        public void RemoveElementTests()
        {
            Remove_Element obj = new Remove_Element();

            var input = new int[] { 3, 2, 2, 3 };
            var resp = obj.RemoveElement(input, 3);

            input = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            resp = obj.RemoveElement(input, 2);
        }
    }
}
