using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LongPressedNameTests
    {
        [TestMethod]
        public void IsLongPressedNameTests()
        {
            LongPressedName obj = new LongPressedName();

            string num1 = "alex", num2 = "aaleex";
            var x = obj.IsLongPressedName(num1, num2);//true

            num1 = "saeed";
            num2 = "ssaaedd";
            x = obj.IsLongPressedName(num1, num2);//false

            num1 = "leelee";
            num2 = "lleeelee";
            x = obj.IsLongPressedName(num1, num2);//true

            num1 = "laiden";
            num2 = "laiden";
            x = obj.IsLongPressedName(num1, num2);//true

            num1 = "xnhtq";
            num2 = "xhhttqq";
            x = obj.IsLongPressedName(num1, num2);//false

            num1 = "pyplrz";
            num2 = "ppyypllr";
            x = obj.IsLongPressedName(num1, num2);//false

        }
    }
}
