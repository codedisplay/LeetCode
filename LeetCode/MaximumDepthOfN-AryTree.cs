using LeetCode.Model;

namespace LeetCode
{
    public class MaximumDepthOfN_AryTree
    {
        public int MaxDepth(NArrayNode root)
        {
            int depth = 0;

            MaxDepthHelper(root, 0, ref depth);

            return depth;
        }

        public void MaxDepthHelper(NArrayNode root, int currentDepth, ref int depth)
        {
            if (root == null) return;

            currentDepth++;

            if (currentDepth > depth)
                depth = currentDepth;

            foreach (var node in root.children)
            {
                MaxDepthHelper(node, currentDepth, ref depth);
            }
        }
    }
}
