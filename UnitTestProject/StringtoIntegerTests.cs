using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class StringtoIntegerTests
    {
        [TestMethod]
        public void MyAtoiTests()
        {
            // Question not clear
            StringtoInteger obj = new StringtoInteger();

            var x = obj.MyAtoi("123");//123

            x = obj.MyAtoi("0032");//32
            x = obj.MyAtoi("   -42");//-42
            x = obj.MyAtoi("4193 with words");//4193
            x = obj.MyAtoi("4-193 with words");//

            x = obj.MyAtoi("words and 987");//0
            x = obj.MyAtoi("+123");//123
            x = obj.MyAtoi("-12");//12
            x = obj.MyAtoi("-+12");//0
            x = obj.MyAtoi("-23a45 567 v");//-23
            x = obj.MyAtoi("123 45 567 v");//123
            x = obj.MyAtoi("a+123 bcd 45");//0

            x = obj.MyAtoi("");//0

            x = obj.MyAtoi("00000-42a1234");//0
            
        }
    }
}