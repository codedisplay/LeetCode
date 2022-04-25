using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ValidParenthesisStringTests
    {
        [TestMethod]
        public void CheckValidStringTests()
        {
            ValidParenthesisString obj = new ValidParenthesisString();

            var x = obj.CheckValidString("()");//t

            x = obj.CheckValidString("(*)");//t

            x = obj.CheckValidString("(*))");//t

            x = obj.CheckValidString("((*)");//t

            x = obj.CheckValidString("(*(*)*)");//t

            x = obj.CheckValidString("()()(((*)");//f


            x = obj.CheckValidString("(())((())()()(*)(*()(())())())()()((()())((()))(*");//f


            x = obj.CheckValidString("((*)(*))((*");//f
            x = obj.CheckValidString("**((*");//f
            x = obj.CheckValidString("*))**");//f
            x = obj.CheckValidString("*(**)");//t

        }
    }
}
