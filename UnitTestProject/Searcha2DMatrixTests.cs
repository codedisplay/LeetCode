using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Searcha2DMatrixTests
    {
        [TestMethod]
        public void SearchMatrixTests()
        {
            Searcha2DMatrix obj = new Searcha2DMatrix();

            var arr = new int[][]
            {
                new int[] {1,   3,  5,  7 },
                new int[] {10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
};

            var x = obj.SearchMatrix(arr, 3);//t


            arr = new int[][]
        {
                new int[] {1,   3,  5,  7 },
                new int[] {10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
};

            x = obj.SearchMatrix(arr, 13);//f
        }
    }

}
