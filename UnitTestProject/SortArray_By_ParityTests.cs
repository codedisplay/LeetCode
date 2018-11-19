using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SortArray_By_ParityTests
    {
        [TestMethod]
        public void SortArrayByParityTests()
        {
            SortArray_By_Parity obj = new SortArray_By_Parity();

            var A = new int[] { 3, 1, 2, 4 };
            var x = obj.SortArrayByParity(A);

            A = new int[] { 3, 1, 2, 4, 5, 6 };
            x = obj.SortArrayByParity(A);

            A = new int[] { 0 };
            x = obj.SortArrayByParity(A);
        }
    }
}
