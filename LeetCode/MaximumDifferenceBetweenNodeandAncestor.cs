using LeetCode.Model;
using System;

namespace LeetCode
{
    public class MaximumDifferenceBetweenNodeandAncestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            int max = 0;
            MaxAncestorDiff(root, root?.val ?? 0, root?.val ?? 0, ref max);
            return max;
        }

        public void MaxAncestorDiff(TreeNode root, int maxParentVal, int minParentVal, ref int max)
        {
            if (root == null)
                return;

            max = Math.Max(Math.Abs(maxParentVal - root.val), max);
            max = Math.Max(Math.Abs(minParentVal - root.val), max);

            MaxAncestorDiff(root.left, Math.Max(maxParentVal, root.val), Math.Min(minParentVal, root.val), ref max);
            MaxAncestorDiff(root.right, Math.Max(maxParentVal, root.val), Math.Min(minParentVal, root.val), ref max);
        }
    }
}
