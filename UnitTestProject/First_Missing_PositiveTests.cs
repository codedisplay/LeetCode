using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class First_Missing_PositiveTests
    {
        [TestMethod]
        public void FirstMissingPositiveTests()
        {
            First_Missing_Positive obj = new First_Missing_Positive();

            int[] nums = new int[] { 1, 2, 0 };
            var x = obj.FirstMissingPositive(nums);
            Assert.AreEqual(x, 3);

            nums = new int[] { -1, -2, 0 };
            x = obj.FirstMissingPositive(nums);
            Assert.AreEqual(x, 1);


            nums = new int[] { 1 };
            x = obj.FirstMissingPositive(nums);
            Assert.AreEqual(x, 2);

            nums = new int[] { -1 };
            x = obj.FirstMissingPositive(nums);
            Assert.AreEqual(x, 1);
        }

    }
}
