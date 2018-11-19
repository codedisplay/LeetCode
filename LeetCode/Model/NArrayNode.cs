using System.Collections.Generic;

namespace LeetCode.Model
{
    public class NArrayNode
    {
        public int val;
        public IList<NArrayNode> children;

        public NArrayNode() { }
        public NArrayNode(int _val, IList<NArrayNode> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
