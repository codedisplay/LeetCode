using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SubsetsIITests
    {
        [TestMethod]
        public void SubsetsWithDupTests()
        {
            SubsetsII obj = new SubsetsII();

            //[
            //  [2],
            //  [1],
            //  [1,2,2],
            //  [2,2],
            //  [1,2],
            //  []
            //]

            var arr = new int[] { 1, 2, 2 };
            var x = obj.SubsetsWithDup(arr);//8 count

             arr = new int[] { 2, 2 };
             x = obj.SubsetsWithDup(arr);

            arr = new int[] { 1 };
            x = obj.SubsetsWithDup(arr);

            arr = new int[] { };
            x = obj.SubsetsWithDup(arr);
        }
    }
}
