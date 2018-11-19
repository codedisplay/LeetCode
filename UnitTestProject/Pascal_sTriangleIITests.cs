using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Pascal_sTriangleIITests
    {
        [TestMethod]
        public void GetRowTests()
        {
            Pascal_sTriangleII obj = new Pascal_sTriangleII();

            var x = obj.GetRow(3);
            x = obj.GetRow(1);
            x = obj.GetRow(0);
            x = obj.GetRow(4);
            x = obj.GetRow(6);
            //optimize your algorithm to use only O(k) extra space
            //MODIFY: make the two for loops to 1
        }
    }
}
