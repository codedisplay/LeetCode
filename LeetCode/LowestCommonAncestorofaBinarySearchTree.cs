using LeetCode.Model;

namespace LeetCode
{
    public class LowestCommonAncestorofaBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;

            if (root.val == p.val || root.val == q.val)
                return root;

            var leftNode = LowestCommonAncestor(root.left, p, q);
            var rightNode = LowestCommonAncestor(root.right, p, q);

            if (leftNode != null && rightNode != null)
                return root;

            if (leftNode != null)
                return leftNode;

            if (rightNode != null)
                return rightNode;

            return null;
        }
    }
}
