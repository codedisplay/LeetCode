using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DegreeofanArrayTests
    {
        [TestMethod]
        public void FindShortestSubArrayTests()
        {
            DegreeofanArray obj = new DegreeofanArray();

            var arr = new int[] { 1, 2, 2, 3, 1 };
            var x = obj.FindShortestSubArray(arr);//2

            arr = new int[] { 1, 2, 2, 3, 1, 4, 2 };
            x = obj.FindShortestSubArray(arr);//6

            arr = new int[] { 1, 2 };
            x = obj.FindShortestSubArray(arr);//2

            arr = new int[] { 1, 2, 1 ,1 };
            x = obj.FindShortestSubArray(arr);//4
        }
    }
}
