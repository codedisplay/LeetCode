using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> openClosePairs = new Dictionary<char, char>()
            {
                { '(',')'},
                { '{','}'},
                { '[',']'}
            };

            Stack<char> stack = new Stack<char>(s.Length);

            foreach (char currentChar in s)
            {
                if (stack.Count == 0)
                    stack.Push(currentChar);
                else
                {
                    char previousChar = stack.Peek();

                    if (openClosePairs.ContainsKey(previousChar) && 
                        openClosePairs[previousChar] == currentChar)
                        stack.Pop();
                    else if (openClosePairs.ContainsKey(currentChar))
                        stack.Push(currentChar);
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
