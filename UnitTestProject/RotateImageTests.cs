using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RotateImageTests
    {
        [TestMethod]
        public void RotateTests()
        {
            RotateImage obj = new RotateImage();

            int[][] arr = new int[][] {
                    new[] { 1,2,3 },
                    new[] { 4,5,6},
                    new[] {7,8,9 }
            };

            //[7,4,1],
            //[8,5,2],
            //[9,6,3]
            obj.Rotate(arr);

            arr = new int[][] {
                    new[] { 5, 1, 9,11 },
                    new[] { 2, 4, 8,10},
                    new[] { 13, 3, 6, 7 },
                    new[] { 15, 14, 12, 16 }
            };

            //[15,13, 2, 5],
            //[14, 3, 4, 1],
            //[12, 6, 8, 9],
            //[16, 7,10,11]
            obj.Rotate(arr);

            arr = new int[][] {
                    new[] { 1,2,3,4 },
                    new[] { 5,6,7,8 },
                    new[] { 9,10,11,12 },
                    new[] {13,14,15,16 }
            };

            obj.Rotate(arr);

            arr = new int[][] {
                    new[] { 1,2,3,4 },
                    new[] { 5,6,7,8 },
                    new[] { 9,10,11,12 },
                    new[] {13,14,15,16 }
            };

            obj.Rotate(arr);

            arr = new int[][] {
            };
            obj.Rotate(arr);

            arr = new int[][] {
                new[] {1 }
            };
            obj.Rotate(arr);

            arr = new int[][] {
                new[] {1,2 },
                new[] { 3,4}
            };
            obj.Rotate(arr);
        }
    }
}
