using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Maximum_SubarrayTests
    {
        [TestMethod]
        public void MaxSubArrayTests()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Maximum_Subarray obj = new Maximum_Subarray();

            var x = obj.MaxSubArray(nums);//6

            nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 , -10};
             x = obj.MaxSubArray(nums);//6

            nums = new int[] { -2, -1};
            x = obj.MaxSubArray(nums);//-1

            nums = new int[] {1,3,-3 };
            x = obj.MaxSubArray(nums);//4

            nums = new int[] { 1, 3, -3, 9 };
            x = obj.MaxSubArray(nums);//10
        }
    }
}
