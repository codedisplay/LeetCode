namespace LeetCode
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            return IsValidBST(root.left, null, root.val) &&
                IsValidBST(root.right, root.val, null);
        }

        private bool IsValidBST(TreeNode root, int? minVal, int? maxVal)
        {
            if (root == null)
                return true;

            if ((minVal != null && root.val <= minVal) ||
                (maxVal != null && root.val >= maxVal))
                return false;

            return IsValidBST(root.left, minVal, root.val) &&
                IsValidBST(root.right, root.val, maxVal);
        }

        //public bool IsValidBST1(TreeNode root)
        //{
        //    if (root == null)
        //        return true;

        //    if ((root.left == null || root.val > root.left.val) &&
        //        (root.right == null || root.val < root.right.val))
        //    {
        //        return IsValidBST(root.left, true, root.val) &&
        //            IsValidBST(root.right, false, root.val);
        //    }

        //    return false;
        //}

        //public bool IsValidBST(TreeNode root, bool isRootLeftNode, int rootVal)
        //{
        //    if (root == null)
        //        return true;

        //    if ((root.left == null || (root.left.val < root.val && (isRootLeftNode || root.left.val > rootVal))) &&
        //        (root.right == null || (root.right.val > root.val && (!isRootLeftNode || root.right.val < rootVal))))
        //    {
        //        return IsValidBST(root.left, isRootLeftNode, rootVal) &&
        //            IsValidBST(root.right, isRootLeftNode, rootVal);
        //    }

        //    return false;
        //}

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }


}
