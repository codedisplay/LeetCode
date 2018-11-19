using LeetCode.Model;

namespace LeetCode
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;

            TreeNode node = new TreeNode((t1?.val ?? 0) + (t2?.val ?? 0))
            {
                left = MergeTrees(t1?.left, t2?.left),
                right = MergeTrees(t1?.right, t2?.right)
            };

            return node;
        }
    }
}
