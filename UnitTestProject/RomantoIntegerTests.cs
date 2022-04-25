using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class RomantoIntegerTests
    {
        [TestMethod]
        public void RomanToIntTests()
        {
            //Symbol Value
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000
            RomantoInteger obj = new RomantoInteger();

            var x = obj.RomanToInt("III");//3

            x = obj.RomanToInt("LVIII");//58
            x = obj.RomanToInt("MCMXCIV");//1994

        }
    }
}