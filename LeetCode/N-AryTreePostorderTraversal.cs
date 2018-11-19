using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class N_AryTreePostorderTraversal
    {
        public IList<int> Postorder(NArrayNode root)
        {
            IList<int> values = new List<int>();

            PostorderHelper(root, ref values);

            return values;
        }

        private void PostorderHelper(NArrayNode root, ref IList<int> values)
        {
            if (root == null) return;

            foreach (var node in root.children)
                PostorderHelper(node, ref values);

            values.Add(root.val);
        }
    }
}
