using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Add_StringsTests
    {
        [TestMethod]
        public void AddStringsTests()
        {
            Add_Strings obj = new Add_Strings();

            string num1 = "12", num2 = "34";
            var x = obj.AddStrings(num1, num2);//46

            num1 = "120";
            num2 = "34";
            x = obj.AddStrings(num1, num2);//154

            num1 = "1";
            num2 = "9";
            x = obj.AddStrings(num1, num2);//10


            num1 = "98";
            num2 = "9";
            x = obj.AddStrings(num1, num2);//107

        }
    }
}
