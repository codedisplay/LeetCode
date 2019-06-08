using LeetCode.Model;

namespace LeetCode
{
    public class FlattenBinaryTreetoLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            FlattenHelper(root);
        }

        public TreeNode FlattenHelper(TreeNode root)
        {
            TreeNode left = root.left;
            TreeNode right = root.right;

            root.left = null;

            TreeNode leafLeft = root;

            if (left != null)
            {
                leafLeft = FlattenHelper(left);
                root.right = left;
            }

            TreeNode leafRight = leafLeft;

            if (right != null)
            {
                leafRight = FlattenHelper(right);
                leafLeft.right = right;
            }

            return leafRight;
        }
    }
}
