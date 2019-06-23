using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ThirdMaximumNumberTests
    {
        [TestMethod]
        public void ThirdMaxTests()
        {
            ThirdMaximumNumber obj = new ThirdMaximumNumber();

            //Input: [3, 2, 1]
            //Output: 1
            var arr = new int[] { 3, 2, 1 };
            var x = obj.ThirdMax(arr);


            arr = new int[] { 1, 2 };
            x = obj.ThirdMax(arr);//2

            arr = new int[] { 2, 2, 3, 1 };
            x = obj.ThirdMax(arr);//1 

            arr = new int[] { 1, 2, int.MinValue };
            x = obj.ThirdMax(arr);//int.MinValue

            arr = new int[] { 1, int.MinValue , 2};
            x = obj.ThirdMax(arr);//int.MinValue

            arr = new int[] { int.MinValue, 1, int.MinValue };
            x = obj.ThirdMax(arr);//1

            arr = new int[] { int.MinValue, 1,2, int.MinValue };
            x = obj.ThirdMax(arr);//int.MinValue

            arr = new int[] { 1, 2,3, int.MinValue };
            x = obj.ThirdMax(arr);//1

            arr = new int[] {  2, int.MinValue };
            x = obj.ThirdMax(arr);//2
        }
    }
}
