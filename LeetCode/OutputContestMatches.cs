namespace LeetCode
{
    public class OutputContestMatches
    {
        // n is no of teams, of form 2^k
        public string FindContestMatch(int n)
        {
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
                arr[i] = (i + 1).ToString();

            int activeItemsInArr = n;

            while (activeItemsInArr != 1)
            {
                for (int j = 0; j < activeItemsInArr / 2; j++)
                {
                    arr[j] = $"({arr[j]},{arr[(activeItemsInArr - 1) - j]})";
                }

                activeItemsInArr = activeItemsInArr / 2;
            }

            return arr[0];
        }
    }
}
