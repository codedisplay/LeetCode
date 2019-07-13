namespace LeetCode
{
    public class LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int index = s.Length - 1;

            while (index >= 0)
            {
                if (s[index] == ' ')
                    return s.Length - index - 1;

                index--;
            }

            return s.Length;
        }
    }
}
