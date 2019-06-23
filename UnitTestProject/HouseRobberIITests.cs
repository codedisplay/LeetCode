using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class HouseRobberIITests
    {
        [TestMethod]
        public void RobTests()
        {
            HouseRobberII obj = new HouseRobberII();
            //        Input: [2, 3, 2]
            //Output: 3

            int[] nums = new int[] { 2, 3, 2 };
            var x = obj.Rob(nums);

            //        Input: [1, 2, 3, 1]
            //Output: 4
            nums = new int[] { 1, 2, 3, 1 };
            x = obj.Rob(nums);

            nums = new int[] { 1 };
            x = obj.Rob(nums);//1

            nums = new int[] { 1, 2 };
            x = obj.Rob(nums);//2


            nums = new int[] { 2, 1, 1, 2 };
            x = obj.Rob(nums);//3

            nums = new int[] { 1, 2, 1, 1 };
            x = obj.Rob(nums);//3
        }
    }
}
