using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class N_AryTreePreorderTraversal
    {
        public IList<int> Preorder(NArrayNode root)
        {
            IList<int> values = new List<int>();

            PreorderHelper(root, ref values);

            return values;
        }

        private void PreorderHelper(NArrayNode root, ref IList<int> values)
        {
            if (root == null) return;

            values.Add(root.val);

            foreach (var node in root.children)
                PreorderHelper(node, ref values);
        }
    }
}
