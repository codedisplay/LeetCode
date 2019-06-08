using LeetCode.Model;
using System;

namespace LeetCode
{
    public class LongestUniValuePath
    {
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null)
                return 0;

            int max = 0;
            LongestUnivaluePath(root, root.val, ref max);
            return max;
        }

        private int LongestUnivaluePath(TreeNode root, int parentVal, ref int max)
        {
            if (root == null)
                return 0;

            int left = LongestUnivaluePath(root.left, root.val, ref max);
            int right = LongestUnivaluePath(root.right, root.val, ref max);

            max = Math.Max(max, left + right);
            int current = root.val==parentVal ? Math.Max(left, right) + 1 : 0;

            return current;
        }
    }
}
