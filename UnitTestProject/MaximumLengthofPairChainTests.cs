using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MaximumLengthofPairChainTests
    {
        [TestMethod]
        public void FindLongestChainTests()
        {
            MaximumLengthofPairChain obj = new MaximumLengthofPairChain();


            int[][] array2D = new int[][]
                    {
                                    new int[] { -10,-8},
                                    new int[] { 8,9 },
                                    new int[] { -5,0},
                                    new int[] { 6,10},
                                    new int[] { -6,-4 },
                                       new int[] { 1,7},
                                    new int[] { 9,10},
                                    new int[] {-4,7 },
                    };
            var x = obj.FindLongestChain(array2D);//4

            array2D = new int[][]
                {
                                    new int[] { 1,2},
                                    new int[] { 2,3 },
                                    new int[] { 3,4},
                };
            x = obj.FindLongestChain(array2D);//2
        }
    }
}
