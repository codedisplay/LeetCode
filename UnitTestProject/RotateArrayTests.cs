using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RotateArrayTests
    {
        [TestMethod]
        public void RotateTests()
        {
            RotateArray obj = new RotateArray();

            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            obj.Rotate(arr, 3);//[5,6,7,1,2,3,4]

            arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            obj.Rotate(arr, 10);//[5,6,7,1,2,3,4]

            arr = new int[] { -1, -100, 3, 99 };
            obj.Rotate(arr, 2);//[3,99,-1,-100]

            arr = new int[] { 1,2,3,4,5,6 };
            obj.Rotate(arr, 3);//[4,5,6,1,2,3]

        }
    }
}