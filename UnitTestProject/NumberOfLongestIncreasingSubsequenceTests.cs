using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NumberOfLongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void FindNumberOfLISTests()
        {
            NumberOfLongestIncreasingSubsequence obj = new NumberOfLongestIncreasingSubsequence();

            var arr = new int[] { 1, 3, 5, 4, 7 };
            var x = obj.FindNumberOfLIS(arr);//2

            arr = new int[] { 2, 2, 2, 2, 2 };
            x = obj.FindNumberOfLIS(arr);//5

            arr = new int[] { 4, 6, 7, 7 };
            x = obj.FindNumberOfLIS(arr);//2  

            //arr = new int[] { 0, 4, 12, 2, 10, 6, 9, 13, 3, 11, 7, 15 };
            //x = obj.FindNumberOfLIS(arr);//

            arr = new int[] { 1, 2, 4, 3, 5, 4, 7, 2 };
            x = obj.FindNumberOfLIS(arr);//3



            arr = new int[] { };
            x = obj.FindNumberOfLIS(arr);//0
        }
    }
}
