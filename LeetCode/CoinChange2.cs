using System.Diagnostics;

namespace LeetCode
{
    public class CoinChange2
    {
        // Using Array
        public int Change(int amount, int[] coins)
        {
            for (int i = 0; i < amount; i++)
            {
                Debug.Write(i + " ");
            }
            Debug.WriteLine("");
            Debug.WriteLine("------------------------------------------------------------------------");

            int[] combinations = new int[amount + 1];

            combinations[0] = 1;

            foreach (var coin in coins)
            {
                for (int i = 1; i < amount + 1; i++)
                {
                    if (i >= coin)
                    {
                        combinations[i] += combinations[i - coin];
                        Print(combinations);
                    }
                }

                Debug.WriteLine("");
            }

            return combinations[amount];
        }

        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Debug.Write(arr[i] + " ");
            }

            Debug.WriteLine("");
        }

        // Using Multi-dimensional Array
        public int Change1(int amount, int[] coins)
        {
            if (amount == 0) return 1;
            int[,] matrix = new int[coins.Length + 1, amount + 1];

            for (int i = 0; i < coins.Length + 1; i++)
            {
                matrix[i, 0] = 1;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    if (coins[i] <= j)
                        matrix[i + 1, j] = matrix[i + 1, j - coins[i]] + matrix[i, j];
                    else
                        matrix[i + 1, j] = matrix[i, j];
                }
            }

            return matrix[coins.Length, amount];
        }
    }
}
