using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class BestTimetoBuyandSellStockwithCooldown
    {
        // TODO
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            Dictionary<int, int> buyingProfits = new Dictionary<int, int>();
            Dictionary<int, int> sellingProfits = new Dictionary<int, int>();
            //MaxProfitNextBuy(prices, 0, 0, buyingProfits, ref maxProfit);

            return maxProfit;
        }

        public int MaxProfitNextBuy(int[] prices, int start, int currentProfit, Dictionary<int, int> buyingProfits, Dictionary<int, int> sellingProfits, ref int maxProfit)
        {
            if (start >= prices.Length)
                return 0;

            if (buyingProfits.ContainsKey(start))
                return buyingProfits[start];

            int current = int.MinValue;

            for (int i = start + 1; i < prices.Length; i++)
            {
                int val = MaxProfitNextSell(prices, i, currentProfit + prices[i - 1], buyingProfits, sellingProfits, ref maxProfit);

                Math.Max(val, current);
            }



            //int profit = MaxProfit()

            buyingProfits[start] = current;

            return currentProfit;
        }

        public int MaxProfitNextSell(int[] prices, int start, int currentProfit, Dictionary<int, int> buyingProfits, Dictionary<int, int> sellingProfits, ref int maxProfit)
        {
            if (start >= prices.Length)
                return 0;

            if (sellingProfits.ContainsKey(start))
                return sellingProfits[start];

            //int profit = MaxProfit()


            return currentProfit;
        }
    }
}
