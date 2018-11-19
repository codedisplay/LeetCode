using LeetCode.Model;

namespace LeetCode
{
    public class SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return SearchBSTHelper(root, val, null, null);
        }

        private TreeNode SearchBSTHelper(TreeNode root, int val, int? minValue, int? maxValue)
        {
            if (root == null || root.val == val)
                return root;
            else if ((minValue.HasValue && root.val < minValue) || (maxValue.HasValue && root.val > maxValue))
                return null;
            else if (root.val < val)
                return SearchBSTHelper(root.right, val, root.val, maxValue);
            else
                return SearchBSTHelper(root.left, val, minValue, root.val);
        }
    }
}
