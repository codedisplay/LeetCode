using System.Text;

namespace LeetCode
{
    public class BullsandCows
    {
        // TODO
        public string GetHint(string secret, string guess)
        {
            StringBuilder sb = new StringBuilder();
            int[] bulls = new int[10];
            bool[] used = new bool[secret.Length];
            int bCount = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bCount++;
                    used[i] = true;
                }
            }

            return sb.ToString();
        }
    }
}
