using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LongestContinuousIncreasingSubsequenceTests
    {
        [TestMethod]
        public void GenerateMatrixTests()
        {
            LongestContinuousIncreasingSubsequence obj = new LongestContinuousIncreasingSubsequence();

            int[] nums = new[] { 1, 3, 5, 4, 7 };
            var x = obj.FindLengthOfLCIS(nums);//3

            nums = new[] { 2, 2, 2, 2, 2 };//1
             x = obj.FindLengthOfLCIS(nums);

            nums = new int[] {  };//
            x = obj.FindLengthOfLCIS(nums);//0

            nums = new int[] {1 };//
            x = obj.FindLengthOfLCIS(nums);//1


            nums = new int[] { 1, 3, 5, 4, 2, 3, 4, 5 };//
            x = obj.FindLengthOfLCIS(nums);//1

        }
    }
}
