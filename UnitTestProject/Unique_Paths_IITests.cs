using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Unique_Paths_IITests
    {
        [TestMethod]
        public void UniquePathsTests()
        {
            Unique_Paths_II obj = new Unique_Paths_II();

            int[][] arr = new int[][] {
                    new[] { 0,0,0 },
                    new[] { 0,1,0 },
                    new[] { 0, 0, 0 }
            };

            var x = obj.UniquePathsWithObstacles(arr);//2




        }
    }
}
