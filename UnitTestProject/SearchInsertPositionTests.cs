using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SearchInsertPositionTests
    {
        [TestMethod]
        public void SearchInsertTests()
        {
            SearchInsertPosition obj = new SearchInsertPosition();

            var arr = new int[] { 1, 3, 5, 6 };
            var x = obj.SearchInsert(arr,5);//2

             arr = new int[] { 1, 3, 5, 6 };
             x = obj.SearchInsert(arr,2);//1

            arr = new int[] { 1, 3, 5, 6 };
            x = obj.SearchInsert(arr, 7);//4

            arr = new int[] { 1, 3, 5, 6 };
            x = obj.SearchInsert(arr, 0);//0

            arr = new int[] { 1, 3, 5, 6 };
            x = obj.SearchInsert(arr, 6);//3
        }
    }
}
