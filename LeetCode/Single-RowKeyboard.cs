using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Single_RowKeyboard
    {
        public int CalculateTime(string keyboard, string word)
        {
            int totalTime = 0;
            int currentIndex = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < keyboard.Length; i++)
                dic[keyboard[i]] = i;

            for (int i = 0; i < word.Length; i++)
            {
                var current = keyboard[currentIndex];
                var lookup = word[i];

                currentIndex += dic[lookup] - dic[current];
                totalTime += Math.Abs(dic[current] - dic[lookup]);
            }

            return totalTime;
        }
    }
}
