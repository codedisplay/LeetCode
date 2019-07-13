using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SquaresofaSortedArrayTests
    {
        [TestMethod]
        public void SortedSquaresTests()
        {
            SquaresofaSortedArray obj = new SquaresofaSortedArray();

            var arr = new int[] { -4, -1, 0, 3, 10 };
            var x = obj.SortedSquares(arr);//[0,1,9,16,100]

            arr = new int[] { -7, -3, 2, 3, 11 };
            x = obj.SortedSquares(arr);//[4,9,9,49,121]

        }
    }
}
