using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Generate_ParenthesesTests
    {
        [TestMethod]
        public void Decode_StringTests()
        {
            Generate_Parentheses obj = new Generate_Parentheses();
            var x= obj.GenerateParenthesis(3);

            x = obj.GenerateParenthesis(0);

            x = obj.GenerateParenthesis(1);

            x = obj.GenerateParenthesis(2);

            x = obj.GenerateParenthesis(4);
        }
    }
}
