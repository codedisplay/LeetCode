using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RangeSumQuery_ImmutableTests
    {
        [TestMethod]
        public void NumArrayTests()
        {
            /**
            * Your NumArray object will be instantiated and called as such:
            * NumArray obj = new NumArray(nums);
            * int param_1 = obj.SumRange(i,j);
            * 
            * Given nums = [-2, 0, 3, -5, 2, -1]

            sumRange(0, 2) -> 1
            sumRange(2, 5) -> -1
            sumRange(0, 5) -> -3
            */
            int[] nums = new int[] { -2, 0, 3, -5, 2, -1 };
            NumArray obj = new NumArray(nums);

            int param_1 = obj.SumRange(0,2);
            param_1 = obj.SumRange(2, 5);
            param_1 = obj.SumRange(0, 5);
        }
    }
}
