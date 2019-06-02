using LeetCode.Model;

namespace LeetCode
{
    public class InorderSuccessorinBST
    {
        public TreeNode InorderSuccessor(TreeNode root, int val)
        {
            TreeNode currentParent = null, parentNode = null;
            TreeNode node = BinarySearch(root, val, currentParent, ref parentNode);

            if (node?.right == null) return parentNode;
            return GetLeftMostNode(node.right);
        }

        private TreeNode BinarySearch(TreeNode node, int val, TreeNode currentParent, ref TreeNode parentNode)
        {
            if (node == null || node.val == val)
            {
                parentNode = currentParent;
                return node;
            }
            else if (node.val < val)
                return BinarySearch(node.right, val, node, ref parentNode);
            else
                return BinarySearch(node.left, val, node, ref parentNode);
        }

        private TreeNode GetLeftMostNode(TreeNode root)
        {
            if (root == null)
                return null;
            else if (root.left == null)
                return root;
            else
                return GetLeftMostNode(root.left);
        }
    }
}
