using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MaximumProductSubarrayTests
    {
        [TestMethod]
        public void MaxProductTests()
        {


            MaximumProductSubarray obj = new MaximumProductSubarray();
            //        Input: [2, 3, -2, 4]
            //Output: 6
            //Explanation: [2, 3] has the largest product 6.

            var arr = new int[] { 2, 3, -2, 4 };
            var x = obj.MaxProduct(arr);


            //        Input: [-2, 0, -1]
            //Output: 0
            //Explanation: The result cannot be 2, because[-2, -1] is not a subarray.
            arr = new int[] { -2, 0, -1 };
            x = obj.MaxProduct(arr);

            arr = new int[] { -3, 0, 1, -2 };
            x = obj.MaxProduct(arr);//1


            arr = new int[] { 3, -1, 4 };
            x = obj.MaxProduct(arr);//4

        }
    }
}
