using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FlipEquivalentBinaryTrees
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;
            if (root1 == null || root2 == null)
                return false;

            bool isValidChildren = (FlipEquiv(root1.left, root2.right) || FlipEquiv(root1.left, root2.left)) 
                && (FlipEquiv(root1.right, root2.left)|| FlipEquiv(root1.right, root2.right));

            return root1?.val == root2.val && isValidChildren;
        }
    }
}
