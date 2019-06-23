using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class EditDistanceTests
    {
        [TestMethod]
        public void ThirdMaxTests()
        {
            EditDistance obj = new EditDistance();

            var x = obj.MinDistance("sea","eat");//2

            x = obj.MinDistance("a", "ab");//1

            x = obj.MinDistance("park", "spake");//3
        }
    }
}
