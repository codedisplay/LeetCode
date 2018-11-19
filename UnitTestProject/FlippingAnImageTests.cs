using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FlippingAnImageTests
    {
        [TestMethod]
        public void FlipAndInvertImageTests()
        {
            FlippingAnImage obj = new FlippingAnImage();

            int[][] arr = new int[][] {
                    new[] { 1, 1, 0},
                    new[] { 1, 0, 1},
                    new[] { 0, 0, 0} };

            var x = obj.FlipAndInvertImage(arr);
        }
    }
}
