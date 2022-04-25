using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class IntegertoRomanTests
    {
        [TestMethod]
        public void IntToRomanTests()
        {
            //Symbol Value
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000
            IntegertoRoman obj = new IntegertoRoman();

            var x = obj.IntToRoman(3);//III

            x = obj.IntToRoman(4);//
            x = obj.IntToRoman(5);//
            x = obj.IntToRoman(7);//

            x = obj.IntToRoman(58);//LVIII
            x = obj.IntToRoman(1994);//MCMXCIV
            x = obj.IntToRoman(3);//
            x = obj.IntToRoman(3);//
        }
    }
}