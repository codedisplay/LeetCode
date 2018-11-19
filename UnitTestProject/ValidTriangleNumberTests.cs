using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TriangleNumberTests
    {
        [TestMethod]
        public void TrimBSTTests()
        {
            ValidTriangleNumber obj = new ValidTriangleNumber();
            
            //1000 ms runtime
            //MODIFY: to lower runtime by using single for loop, rather than two
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            var resp = obj.TriangleNumber(nums);

            nums = new int[] { 2, 2, 3, 4 };
            resp = obj.TriangleNumber(nums);

            nums = new int[] { 0, 2, 3, 4 };
            resp = obj.TriangleNumber(nums);

            nums = new int[] { 0, 0, 0, 0 };
            resp = obj.TriangleNumber(nums);

            nums = new int[] { 0, 0, 2, 3 };
            resp = obj.TriangleNumber(nums);

 

        }
    }
}
