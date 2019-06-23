using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class HouseRobberTests
    {
        [TestMethod]
        public void RobTests()
        {
            HouseRobber obj = new HouseRobber();
            //        Input: [1, 2, 3, 1]
            //Output: 4        }

            int[] nums = new int[] { 1, 2, 3, 1 };
            var x = obj.Rob(nums);

            //        Input: [2, 7, 9, 3, 1]
            //Output: 12
            nums = new int[] { 2, 7, 9, 3, 1 };
            x = obj.Rob(nums);
        }
    }
}
