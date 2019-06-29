using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LargestPlusSignTests
    {
        [TestMethod]
        public void OrderOfLargestPlusSignTests()
        {
            LargestPlusSign obj = new LargestPlusSign();

            var arr = new int[][]
            {
                new int[] { 2,0 }
            };

            var x = obj.OrderOfLargestPlusSign(3, arr);//2


            arr = new int[][]
            {
                new int[] { 4, 2 }
            };

            x = obj.OrderOfLargestPlusSign(5, arr);//2

            arr = new int[][]
            {
                            new int[] { }
            };

            x = obj.OrderOfLargestPlusSign(2, arr);//1


            arr = new int[][]
            {
                            new int[] {0,0}
            };

            x = obj.OrderOfLargestPlusSign(1, arr);//0

            arr = new int[][]
            {
                            new int[] { }
            };

            x = obj.OrderOfLargestPlusSign(1, arr);//1

            arr = new int[][]
            {
                new int[] { }
            };

            x = obj.OrderOfLargestPlusSign(0, arr);//0


            arr = new int[][]
            {
                new int[] {0,0 },
                new int[] {0,1 },
                new int[] {1,0 }
};

            x = obj.OrderOfLargestPlusSign(2, arr);//1

            arr = new int[][]
{new int[] {0,0},new int[] {0,1},new int[] {0,2},new int[] {0,7},new int[] {1,2},new int[] {1,3},new int[] {1,9},new int[] {2,3},new int[] {2,5},new int[] {2,7},new int[] {2,8},new int[] {3,2},new int[] {3,5},new int[] {3,7},new int[] {4,2},new int[] {4,3},new int[] {4,5},new int[] {4,7},new int[] {5,1},new int[] {5,4},new int[] {5,8},new int[] {5,9},new int[] {7,2},new int[] {7,5},new int[] {7,7},new int[] {7,8},new int[] {8,5},new int[] {8,8},new int[] {9,0},new int[] {9,1},new int[] {9,2},new int[] {9,8}};

            x = obj.OrderOfLargestPlusSign(10, arr);//4
        }
    }

}
