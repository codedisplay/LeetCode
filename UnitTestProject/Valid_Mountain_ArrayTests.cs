using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Valid_Mountain_ArrayTests
    {
        [TestMethod]
        public void ValidMountainArrayTests()
        {
            Valid_Mountain_Array obj = new Valid_Mountain_Array();

            var values = new int[] { 2, 1 };
            var x = obj.ValidMountainArray(values);//f

            values = new int[] { 3, 5, 5 };
            x = obj.ValidMountainArray(values);//f

            values = new int[] { 0, 3, 2, 1 };
            x = obj.ValidMountainArray(values);//t

            values = new int[] { 0, 3, 2, 1 };
            x = obj.ValidMountainArray(values);//t


            values = new int[] { 1, 3, 2 };
            x = obj.ValidMountainArray(values);//t

            values = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            x  = obj.ValidMountainArray(values);
        }

    }
}
