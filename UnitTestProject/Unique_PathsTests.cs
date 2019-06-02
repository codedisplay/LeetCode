using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Unique_PathsTests
    {
        [TestMethod]
        public void UniquePathsTests()
        {
            Unique_Paths obj = new Unique_Paths();

            var x = obj.UniquePaths(3, 2);//3

            x = obj.UniquePaths(7, 3);//28

            x = obj.UniquePaths(1, 1);//1

            x = obj.UniquePaths(0, 1);//0

        }
    }
}
