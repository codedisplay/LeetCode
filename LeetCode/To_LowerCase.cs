using System.Text;

namespace LeetCode
{
    public class To_LowerCase
    {
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] > 64 && (int)str[i] < 91)
                    sb.Append((char)(str[i] + 32));
                else
                    sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
