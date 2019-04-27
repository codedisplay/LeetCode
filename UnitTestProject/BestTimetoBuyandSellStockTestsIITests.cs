using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BestTimetoBuyandSellStockIITests
    {
        [TestMethod]
        public void MaxProfit()
        {
            BestTimetoBuyandSellStockII obj = new BestTimetoBuyandSellStockII();
            //[7,1,5,3,6,4] - 5
            int[] arr = new int[] { 7, 1, 5, 3, 6, 4 };
            int val=obj.MaxProfit(arr);

            //[1,2,3,4,5] - 4
            arr = new int[] { 1, 2, 3, 4, 5 };
            val = obj.MaxProfit(arr);

            //[7,6,4,3,1] - 0
            arr = new int[] { 7, 6, 4, 3, 1 };
            val=obj.MaxProfit(arr);

            //[2,1,2,0,1] - 2
            arr = new int[] { 2, 1, 2, 0, 1 };
            val = obj.MaxProfit(arr);
        }
    }
}
