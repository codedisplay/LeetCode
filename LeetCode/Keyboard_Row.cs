using System.Collections.Generic;

namespace LeetCode
{
    public class Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            var top = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            var middle = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            var bottom = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'k' };

            List<string> values = new List<string>();
            HashSet<char> current = null;

            foreach (var word in words)
            {
                if (word.Length == 0) continue;
                else if (top.Contains(char.ToLower(word[0])))
                    current = top;
                else if (middle.Contains(char.ToLower(word[0])))
                    current = middle;
                else if (bottom.Contains(char.ToLower(word[0])))
                    current = bottom;

                int i;
                for (i = 1; i < word.Length; i++)
                {
                    if (!current.Contains(char.ToLower(word[i])))
                        break;
                }

                if (i == word.Length)
                    values.Add(word);
            }

            return values.ToArray();
        }
    }
}
