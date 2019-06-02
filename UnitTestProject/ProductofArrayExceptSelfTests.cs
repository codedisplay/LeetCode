using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ProductofArrayExceptSelfTests
    {
        [TestMethod]
        public void RotateTests()
        {
            ProductofArrayExceptSelf obj = new ProductofArrayExceptSelf();

            int[] nums = new[] { 1, 2, 3, 4 };
            var x = obj.ProductExceptSelf(nums);//[24,12,8,6]


            nums = new[] {2,2,2,2};
            x = obj.ProductExceptSelf(nums);//[24,12,8,6]

            nums = new[] { 2};
            x = obj.ProductExceptSelf(nums);

            nums = new[] { 2,2 };
            x = obj.ProductExceptSelf(nums);

            nums = new int[] { };
            x = obj.ProductExceptSelf(nums);

        }
    }
}
