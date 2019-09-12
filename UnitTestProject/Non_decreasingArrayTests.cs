using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Non_decreasingArrayTests
    {
        [TestMethod]
        public void CheckPossibilityTests()
        {
            Non_decreasingArray obj = new Non_decreasingArray();

            var arr = new int[] { 4, 2, 3 };
            var x = obj.CheckPossibility(arr);//t

            arr = new int[] { 4, 2, 1 };
            x = obj.CheckPossibility(arr);//f

            arr = new int[] { 3, 4, 2, 3 };
            x = obj.CheckPossibility(arr);//f

            arr = new int[] { 3 };
            x = obj.CheckPossibility(arr);//t


            arr = new int[] { 2, 3, 3,2, 4 };
            x = obj.CheckPossibility(arr);//t
        }
    }
}
