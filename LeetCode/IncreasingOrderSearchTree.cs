using LeetCode.Model;

namespace LeetCode
{
    public class IncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode parent = new TreeNode(0);
            TreeNode parentReference = parent;

            IncreasingBSTHelper(root, ref parentReference);

            return parent.right;
        }


        public static void IncreasingBSTHelper(TreeNode node, ref TreeNode parent)
        {
            if (node == null) return;

            IncreasingBSTHelper(node.left, ref parent);

            node.left = null;
            parent.right = node;
            parent = node;

            IncreasingBSTHelper(node.right, ref parent);
        }

        //private static TreeNode IncreasingBSTHelper(TreeNode node)
        //{
        //    TreeNode current = null;

        //    if (node.left != null)
        //    {
        //        current = IncreasingBSTHelper(node.left);
        //        current.right = new TreeNode(node.val);

        //        if (node.right != null)
        //        {
        //            current.right.right = IncreasingBSTHelper(node.right);
        //        }
        //    }
        //    else
        //    {
        //            if (node.right != null)
        //            {
        //                current = new TreeNode(node.val)
        //                {
        //                    right = IncreasingBSTHelper(node.right)
        //                };
        //            }
        //            else
        //                return node;
        //    }

        //    return current;
        //}

        //TreeNode node = new TreeNode(3)
        //{
        //    left = new TreeNode(0) { right = new TreeNode(2) { left = new TreeNode(1) } },
        //    right = new TreeNode(4) { }
        //};

    }
}
