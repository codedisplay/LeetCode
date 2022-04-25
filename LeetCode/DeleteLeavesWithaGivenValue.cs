using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DeleteLeavesWithaGivenValue
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null)
                return root;

            var parent = new TreeNode(0) { left = root };

            RemoveLeafNodesHelper(root, target, parent, true);

            return parent.left;
        }

        public bool RemoveLeafNodesHelper(TreeNode root, int target, TreeNode parent, bool isLeft)
        {
            if (root == null)
                return true;

            bool isRemove = RemoveLeafNodesHelper(root.left, target, root, true);

            if (RemoveLeafNodesHelper(root.right, target, root, false) &&
                isRemove)
            {
                if (root.val == target)
                {
                    if (isLeft)
                        parent.left = null;
                    else
                        parent.right = null;

                    return true;
                }
            }

            return false;
        }
    }
}
