using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LetterCombinationsofaPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> list = new List<string>();

            if (digits.Length == 0)
                return list;

            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>()
            {
                { '2', new List<char>{ 'a', 'b' , 'c'} },
                { '3', new List<char>{ 'd', 'e' , 'f'} },
                { '4', new List<char>{ 'g', 'h' , 'i'} },
                { '5', new List<char>{ 'j', 'k' , 'l'} },
                { '6', new List<char>{ 'm', 'n' , 'o'} },
                { '7', new List<char>{ 'p', 'q' , 'r', 's'} },
                { '8', new List<char>{ 't', 'u' , 'v'} },
                { '9', new List<char>{ 'w', 'x' , 'y' , 'z'} }
            };

            Helper(digits, digits.ToCharArray(), 0, list, dic);

            return list;
        }

        private void Helper(string digits, char[] S, int index, IList<string> list, Dictionary<char, List<char>> dic)
        {
            if (index == S.Length)
            {
                list.Add(new string(S));
                return;
            }

            for (int i = 0; i < dic[digits[index]].Count; i++)
            {
                S[index] = dic[digits[index]][i];
                Helper(digits, S, index + 1, list, dic);
            }
        }
    }
}
