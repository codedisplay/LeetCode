using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SortArrayByParity_IITests
    {
        [TestMethod]
        public void SortArrayByParityIITests()
        {
            SortArrayByParity_II obj = new SortArrayByParity_II();

            var x = obj.SortArrayByParityII(new int[] { 4, 2, 5, 7 });
            x = obj.SortArrayByParityII(new int[] { 2, 3, 1, 1, 4, 0, 0, 4, 3, 3 });//[2,3,0,1,4,1,0,3,4,3]


        }
    }
}
