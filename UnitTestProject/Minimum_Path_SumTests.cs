using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Minimum_Path_SumTests
    {
        [TestMethod]
        public void MinPathSumTests()
        {
            Minimum_Path_Sum obj = new Minimum_Path_Sum();

            int[][] arr = new int[][] {
                    new[] { 1,3,1 },
                    new[] { 1,5,1},
                    new[] { 4, 2, 1 }
            };

            var x = obj.MinPathSum(arr);//




        }
    }
}
