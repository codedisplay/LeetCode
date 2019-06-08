using LeetCode.Model;

namespace LeetCode
{
    public class BinaryTreePruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
                return null;

            return PruneTreeHelper(root);
        }

        public TreeNode PruneTreeHelper(TreeNode root)
        {
            if (root.left != null)
                root.left = PruneTreeHelper(root.left);

            if (root.right != null)
                root.right = PruneTreeHelper(root.right);

            if (root.left == null && root.right == null && root.val == 0)
                return null;

            return root;
        }
    }
}
