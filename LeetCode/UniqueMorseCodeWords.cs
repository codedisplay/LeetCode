using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            //a-z 97-122
            string[] morseCodes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            List<string> values = new List<string>();

            foreach (var word in words)
            {
                StringBuilder current = new StringBuilder();

                for (int i = 0; i < word.Length; i++)
                {
                    current.Append(morseCodes[word[i] - 97]);
                }

                if (!values.Contains(current.ToString()))
                    values.Add(current.ToString());
            }

            return values.Count();
        }
    }
}
