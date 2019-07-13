using System.Collections.Generic;

namespace LeetCode
{
    public class Letter_Case_Permutation
    {
        public IList<string> LetterCasePermutation(string S)
        {
            IList<string> list = new List<string>();

            Helper(S.ToCharArray(), 0, list);

            return list;
        }

        private void Helper(char[] S, int index, IList<string> list)
        {
            if (index == S.Length)
            {
                list.Add(new string(S));
                return;
            }

            if (char.IsDigit(S[index]))
            {
                Helper(S, index + 1, list);
            }
            else
            {
                S[index] = char.ToUpper(S[index]);
                Helper(S, index + 1, list);

                S[index] = char.ToLower(S[index]);
                Helper(S, index + 1, list);
            }
        }
    }
}
