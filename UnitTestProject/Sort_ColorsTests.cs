using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Sort_ColorsTests
    {
        [TestMethod]
        public void SortColorsTests()
        {
            Sort_Colors obj = new Sort_Colors();
            //   Input: [2,0,2,1,1,0]
            //  Output: [0,0,1,1,2,2]

            var arr = new int[] { 2, 0, 2, 1, 1, 0 };
            obj.SortColors(arr);

            arr = new int[] { 2, 2, 1, 1};
            obj.SortColors(arr);

            arr = new int[] { 2, 2, 0,0 };
            obj.SortColors(arr);

            arr = new int[] {1, 2, 2, 0, 0 };
            obj.SortColors(arr);


            arr = new int[] { 1};
            obj.SortColors(arr);
        }
    }
}
