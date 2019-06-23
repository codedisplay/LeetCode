using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void MinimumTotalTests()
        {
            Triangle obj = new Triangle();

            IList<IList<int>> triangle = new List<IList<int>>() {
                new List<int> {2 },
                new List<int> {3,4 },
                new List<int> {6,5,7 },
                new List<int> {4,1,8,3 }
            };
           Assert.AreEqual(obj.MinimumTotal(triangle),11);

            triangle = new List<IList<int>>() {
                new List<int> {2 }
            };
            Assert.AreEqual(obj.MinimumTotal(triangle), 2);

            triangle = new List<IList<int>>() {
                new List<int> {-1 },
                new List<int> {3,2 },
                new List<int> {-3,1,-1 },
            };
            Assert.AreEqual(obj.MinimumTotal(triangle), -1);

        }
    }
}
