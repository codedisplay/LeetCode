namespace LeetCode
{
    public class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0, currentMin = int.MaxValue, currentMax = 0, currentMaxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= currentMin || prices[i] <= currentMax)
                {
                    maxProfit += currentMaxProfit;

                    currentMaxProfit = 0;
                    currentMin = prices[i];
                    currentMax = 0;
                }
                else if (prices[i] - currentMin >= currentMaxProfit)
                {
                    currentMaxProfit = prices[i] - currentMin;
                    currentMax = prices[i];
                }
            }

            maxProfit += currentMaxProfit;

            return maxProfit;
        }
    }
}
