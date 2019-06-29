using System;

namespace LeetCode
{
    public class Coin_Change
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] arr = new int[amount + 1];
            Array.Fill(arr, amount + 1);
            arr[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        arr[i] = Math.Min(arr[i], arr[i - coins[j]] + 1);
                    }
                }
            }

            return arr[amount] > amount ? -1 : arr[amount];
        }

        //public int CoinChange(int[] coins, int amount)
        //{
        //    int[] arr = new int[amount + 1];
        //    Array.Sort(arr);

        //    arr[0] = 0;
        //    int previousCoinIndex = -1;

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (previousCoinIndex < coins.Length - 1 && coins[previousCoinIndex + 1] == i)
        //        {
        //            arr[i] = 1;
        //            previousCoinIndex++;
        //        }
        //        else if (previousCoinIndex != -1)
        //        {
        //            int lastCoin = coins[previousCoinIndex];
        //            arr[i] = arr[lastCoin] + arr[i - previousCoinIndex];

        //            Math.Min(arr[i], arr[i - coins[previousCoinIndex]] + 1);
        //        }
        //    }

        //    return arr[amount] == 0 ? -1 : arr[amount]; 
        //}
    }
}
