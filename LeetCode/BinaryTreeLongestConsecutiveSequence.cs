using LeetCode.Model;
using System;

namespace LeetCode
{
    public class BinaryTreeLongestConsecutiveSequence
    {
        public int LongestConsecutive(TreeNode root)
        {
            return LongestConsecutive(root, int.MinValue, 0);
        }

        public int LongestConsecutive(TreeNode root, int parent, int current)
        {
            if (root == null)
                return current;

            current = root.val == parent + 1 ? current + 1 : 1;

            int left = LongestConsecutive(root.left, root.val, current);

            int right = LongestConsecutive(root.right, root.val, current);

            return Math.Max(current, Math.Max(left, right));
        }
    }
}
