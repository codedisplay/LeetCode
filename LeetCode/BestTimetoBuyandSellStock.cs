namespace LeetCode
{
    public class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int currentMin = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < currentMin)
                {
                    currentMin = prices[i];
                }
                else if(prices[i]-currentMin > maxProfit)
                {
                    maxProfit = prices[i] - currentMin;
                }
            }

            return maxProfit;
        }
    }
}
