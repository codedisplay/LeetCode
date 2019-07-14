using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class HappyNumberTests
    {
        [TestMethod]
        public void IsHappyTests()
        {
            HappyNumber obj = new HappyNumber();

            var x = obj.IsHappy(2);//f
            x = obj.IsHappy(19);//t
        }
    }
}