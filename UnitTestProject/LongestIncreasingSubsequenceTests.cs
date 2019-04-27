using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void LengthOfLISTests()
        {
            LongestIncreasingSubsequence obj = new LongestIncreasingSubsequence();

            var arr = new int[] { 0, 4, 12, 2, 10, 6, 9, 13, 3, 11, 7, 15 };
            var x = obj.LengthOfLIS(arr);//6

            arr = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            x = obj.LengthOfLIS(arr);//4

            arr = new int[] {};
            x = obj.LengthOfLIS(arr);//0
        }
    }
}
