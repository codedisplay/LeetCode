using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NumberofSubarrayswithBoundedMaximumTestsNumberofSubarrayswithBoundedMaximum
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            NumberofSubarrayswithBoundedMaximum obj = new NumberofSubarrayswithBoundedMaximum();

            int[] nums = { 2, 1, 4, 3 };
            var x = obj.NumSubarrayBoundedMax(nums,2,3);//3

            nums = new int[]{ 2, 1, 4, 3 };
            x = obj.NumSubarrayBoundedMax(nums, 3, 3);//1

            nums = new int[] { 2, 1, 4, 3 };
            x = obj.NumSubarrayBoundedMax(nums, 1, 5);//

            nums = new int[] { 73, 55, 36, 5, 55, 14, 9, 7, 72, 52 };
            x = obj.NumSubarrayBoundedMax(nums, 32,69);//22

            nums = new int[] { 482, 260, 132, 421, 732, 703, 795, 420, 871, 445, 400, 291, 358, 589, 617, 202, 755, 810, 227, 813, 549, 791, 418, 528, 835, 401, 526, 584, 873, 662, 13, 314, 988, 101, 299, 816, 833, 224, 160, 852, 179, 769, 646, 558, 661, 808, 651, 982, 878, 918, 406, 551, 467, 87, 139, 387, 16, 531, 307, 389, 939, 551, 613, 36, 528, 460, 404, 314, 66, 111, 458, 531, 944, 461, 951, 419, 82, 896, 467, 353, 704, 905, 705, 760, 61, 422, 395, 298, 127, 516, 153, 299, 801, 341, 668, 598, 98, 241 };
            x = obj.NumSubarrayBoundedMax(nums, 658,719);//19


        }

    }
}
