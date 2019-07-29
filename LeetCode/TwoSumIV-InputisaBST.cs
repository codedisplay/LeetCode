using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSumIV_InputisaBST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> dic = new HashSet<int>();
            return FindTargetHelper(root, k, dic);
        }

        private bool FindTargetHelper(TreeNode root, int k, HashSet<int> dic)
        {
            if (root == null)
                return false;

            if (dic.Contains(k - root.val))
                return true;

            dic.Add(root.val);

            return FindTargetHelper(root.left, k, dic) || FindTargetHelper(root.right, k, dic);
        }


        //public bool FindTarget(TreeNode root, int k)
        //{
        //    TreeNode correctNode = FindCorrectRoot(root, k);

        //    return FindTargetHelper(root, root, k);
        //}

        //public TreeNode FindCorrectRoot(TreeNode root, int k)
        //{
        //    if (root?.val == k)
        //        return null;

        //    if (root.val > k)
        //        return FindCorrectRoot(root.left, k);

        //    return root;
        //}

        //public bool FindTargetHelper(TreeNode current, TreeNode root, int k)
        //{
        //    if (current == null)
        //        return false;

        //    if (current.val == k)
        //        return false;

        //    bool isExists = false;

        //    if (current.val > k)
        //        isExists = IsExists(current.left, k - current.val);
        //    else
        //        isExists = IsExists(root, k - current.val);

        //    if (isExists)
        //        return true;

        //    isExists = FindTargetHelper(current.left, root, k);

        //    if (isExists)
        //        return true;

        //    isExists = FindTargetHelper(current.right, root, k);

        //    if (isExists)
        //        return true;

        //    return isExists;
        //}

        //public bool IsExists(TreeNode root, int k)
        //{
        //    if (root == null)
        //        return false;

        //    if (root.val == k)
        //        return true;

        //    if (root.val < k)
        //        return IsExists(root.right, k);

        //    return IsExists(root.left, k);
        //}


    }
}
