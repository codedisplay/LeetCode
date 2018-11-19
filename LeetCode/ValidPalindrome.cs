namespace LeetCode
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                    i++;
                else if (!char.IsLetterOrDigit(s[j]))
                    j--;
                else if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
