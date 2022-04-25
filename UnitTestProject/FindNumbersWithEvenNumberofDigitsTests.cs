using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindNumbersWithEvenNumberofDigitsTests
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            FindNumbersWithEvenNumberofDigits obj = new FindNumbersWithEvenNumberofDigits();

            int[] nums = { 12, 345, 2, 6, 7896 };
            var x = obj.FindNumbers(nums);

        }

    }
}
