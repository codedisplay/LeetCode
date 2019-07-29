using System.Collections.Generic;

namespace LeetCode
{
    public class Most_Common_Word
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> lookup = new HashSet<string>(banned);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string maxString = "";
            int maxFreq = 0;
            var words = paragraph.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                int j = words[i].Length - 1;

                while (j > -1 && !char.IsLetter(words[i][j]))
                    j--;

                string[] currentArr = words[i].Substring(0, j + 1).ToLower().Split(",") ;

                for (int k = 0; k < currentArr.Length; k++)
                {
                    string current = currentArr[k];


                    if (current.Length > 0 && !lookup.Contains(current))
                    {
                        if (!dic.ContainsKey(current))
                            dic.Add(current, 1);
                        else
                            dic[current]++;

                        var currentCount = dic[current];
                        if (currentCount > maxFreq)
                        {
                            maxFreq = currentCount;
                            maxString = current;
                        }
                    }
                }
            }

            return maxString;
        }
    }
}
