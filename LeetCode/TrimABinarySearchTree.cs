using LeetCode.Model;

namespace LeetCode
{
    public class TrimABinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            if (root.val >= L && root.val <= R)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
            }
            else if (root.val < L)
                return TrimBST(root.right, L, R);
            else if (root.val > R)
                return TrimBST(root.left, L, R);

            return root;
        }
    }
}
