using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Majority_ElementIITests
    {
        [TestMethod]
        public void MajorityElementTests()
        {
            Majority_ElementII obj = new Majority_ElementII();

            var arr = new int[] { 3, 2, 3 };
            var x = obj.MajorityElement(arr);//3

            arr = new int[] { 1, 1, 1, 3, 3, 2, 2, 2 };
            x = obj.MajorityElement(arr);//1,2
        }
    }
}