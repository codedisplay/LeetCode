using System.Collections.Generic;

namespace LeetCode.Model
{
    public class TrieNode
    {
        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
        }

        public Dictionary<char, TrieNode> Children { get; set; }

        public bool IsCompletedWord { get; set; }
    }
}
