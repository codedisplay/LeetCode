using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RottingOrangesTest
    {
        [TestMethod]
        public void OrangesRottingTest()
        {
            RottingOranges obj = new RottingOranges();

            int[][] arr = new int[][] {
                    new[] { 2,1,1 },
                    new[] { 1,1,0 },
                    new[] { 0,1,1 }
            };

            var x = obj.OrangesRotting(arr);//4

            arr = new int[][] {
                    new[] { 0,2}
            };

           x = obj.OrangesRotting(arr);//0

            arr = new int[][] {
                    new[] { 2,1,1 },
                    new[] { 0,1,1 },
                    new[] { 1,0,1 }
            };

             x = obj.OrangesRotting(arr);


        }
    }
}
