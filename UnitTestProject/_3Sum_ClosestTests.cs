using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class _3Sum_ClosestTests
    {
        [TestMethod]
        public void ThreeSumClosestTests()
        {
            int[] nums = new int[] { -4, -1, 1, 2 };
            //target = 1.
            //The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
            _3Sum_Closest obj = new _3Sum_Closest();

            var x = obj.ThreeSumClosest(nums, 1);


            nums = new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            //target = 8
            x = obj.ThreeSumClosest(nums, 8);//9
            x = obj.ThreeSumClosest(nums, 2);//9

            nums = new int[] { -3, -3, -3, -3 };
            //target = 8
            x = obj.ThreeSumClosest(nums, 8);//-9
            x = obj.ThreeSumClosest(nums, 2);//-9

            nums = new int[] { 0, 0, 0 };
            x = obj.ThreeSumClosest(nums, 1);//0

            nums = new int[] { 0, 1, 2 };
            x = obj.ThreeSumClosest(nums, 0);//3


            nums = new int[] { 1, 1, -1 };
            x = obj.ThreeSumClosest(nums, 2);//1



            nums = new int[] { 0, 1, 1, 1 };
            x = obj.ThreeSumClosest(nums, -100);//2


            nums = new int[] { -1, -1, 1, 1, 3 };
            x = obj.ThreeSumClosest(nums, -1);//-1
     
    }
    }
}
