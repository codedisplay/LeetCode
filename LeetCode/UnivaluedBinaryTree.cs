using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
                return true;

            return IsUnivalTree(root, root.val);
        }

        public bool IsUnivalTree(TreeNode root, int prevValue)
        {
            if (root == null)
                return true;

            if (root.val != prevValue)
                return false;

            return IsUnivalTree(root.left, root.val) && IsUnivalTree(root.right, root.val);
        }
    }
}
