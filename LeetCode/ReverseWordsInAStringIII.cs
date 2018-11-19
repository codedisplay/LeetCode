using System.Text;

namespace LeetCode
{
    public class ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            if (s == null) return s;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                int strtIndex = i;

                while (i < s.Length && s[i] != ' ')
                    i++;

                for (int j = i - 1; j >= strtIndex; j--)
                    sb.Append(s[j]);

                if (i < s.Length)
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
