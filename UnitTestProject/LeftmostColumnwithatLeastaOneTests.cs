using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class LeftmostColumnwithatLeastaOneTests
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            LeftmostColumnwithatLeastaOne obj = new LeftmostColumnwithatLeastaOne();

            var x = obj.LeftMostColumnWithOne(new Temp());

        }

    }

    
    public class Temp : BinaryMatrix
    {
        public IList<int> Dimensions()
        {
            return new List<int> { 2, 2 };
        }

        public int Get(int row, int col)
        {
            //mock response
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                { "00", 0},
                { "01", 1},
                { "10", 1},
                { "11", 1}
            };

            return dic[row + "" + col];
        }
    }
}
