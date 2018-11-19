using LeetCode.Model;

namespace LeetCode
{
    public class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetric(root.left, root.right);
        }

        public static bool IsSymmetric(TreeNode leftRoot, TreeNode rightRoot)
        {
            if (leftRoot == null && rightRoot == null)
                return true;

            if (leftRoot == null || rightRoot == null)
                return false;

            if (!leftRoot.val.Equals(rightRoot.val)) return false;
            if (!IsSymmetric(leftRoot.left, rightRoot.right)) return false;
            if (!IsSymmetric(leftRoot.right, rightRoot.left)) return false;

            return true;
        }
    }
}
