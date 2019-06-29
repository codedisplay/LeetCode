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

            arr = new int[] { 1, 2, 2, 2, 2, 2 };
            x = obj.FindNumberOfLIS(arr);//5

            arr = new int[] { 1, 2, 2, 2, 2, 2, 3 };
            x = obj.FindNumberOfLIS(arr);//5

            arr = new int[] { 4, 6, 7, 7 };
            x = obj.FindNumberOfLIS(arr);//2  

            arr = new int[] { 1, 2, 4, 3, 5, 4, 7, 2 };
            x = obj.FindNumberOfLIS(arr);//2

            arr = new int[] { };
            x = obj.FindNumberOfLIS(arr);//0

            arr = new int[] { 1, 2 };
            x = obj.FindNumberOfLIS(arr);//1

            arr = new int[] { 1 };
            x = obj.FindNumberOfLIS(arr);//1
             
            // 1,2,4,5,7
            // 1,2,3,5,7
            // 1,2,3,4,7

            arr = new int[] { 1, 2, 4, 3, 5, 4, 7, 2 };
            x = obj.FindNumberOfLIS(arr);//3
        }
    }
}
