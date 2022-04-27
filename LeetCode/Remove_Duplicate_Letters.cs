using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Remove_Duplicate_Letters
    {
        public string RemoveDuplicateLetters(string s)
        {
            Stack<char> stack = new Stack<char>();
            HashSet<char> visited = new HashSet<char>();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
                dic[s[i]] = i;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (visited.Contains(current))
                    continue;

                while (stack.Count > 0 && stack.Peek() > current 
                    && dic.ContainsKey(stack.Peek()) && dic[stack.Peek()] > i)
                {
                    stack.Pop();
                    visited.Remove(stack.Peek());
                }

                stack.Push(current);
                visited.Add(current);
            }

            return string.Join("", stack.Reverse());
        }
    }
}
