using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Majority_ElementTests
    {
        [TestMethod]
        public void MajorityElementTests()
        {
            Majority_Element obj = new Majority_Element();

            var arr = new int[] { 3, 2, 3 };
            var x = obj.MajorityElement(arr);//3

            arr = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            x = obj.MajorityElement(arr);//2
        }
    }
}