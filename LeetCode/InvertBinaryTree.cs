using LeetCode.Model;

namespace LeetCode
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode invertedLeft = InvertTree(root.left);
            TreeNode invertedRight = InvertTree(root.right);

            root.left = invertedRight;
            root.right = invertedLeft;

            return root;
        }
    }
}
