using LeetCode.Model;

namespace LeetCode
{
    public class LowestCommonAncestorOfaBinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            int valuesFound = 0;
            return LowestCommonAncestor(root, p, q, ref valuesFound);
        }

        private TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q, ref int valuesFound)
        {
            if (root == null || valuesFound == 2)
                return null;

            //if (root.Equals(p) || root.Equals(q))//if (root.val == p.val || root.val == q.val)
            if (root.val == p.val || root.val == q.val)
            {
                valuesFound++;

                LowestCommonAncestor(root.left, p, q, ref valuesFound);
                LowestCommonAncestor(root.right, p, q, ref valuesFound);

                return root;
            }

            TreeNode left = LowestCommonAncestor(root.left, p, q, ref valuesFound);
            TreeNode right = LowestCommonAncestor(root.right, p, q, ref valuesFound);

            if (left != null && right != null)
                return root;
            else if (left != null)
                return left;
            else if (right != null)
                return right;

            return null;
        }

        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null)
        //        return null;

        //    if (root == p || root == q)
        //        return root;

        //    if (LowestCommonAncestor(root.left, p, q) != null &&
        //        LowestCommonAncestor(root.right, p, q) != null)
        //        return root;

        //    return null;
        //}

        //private TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q, ref int valuesFound)
        //{
        //    if (root == null)
        //        return null;

        //    if (root == p || root == q)
        //        valuesFound++;

        //    if (valuesFound == 2)
        //        return root;

        //    TreeNode left = LowestCommonAncestor(root.left, p, q, ref valuesFound);

        //    if (left != null && valuesFound == 2) return left;

        //    TreeNode right = LowestCommonAncestor(root.right, p, q, ref valuesFound);

        //    if (right != null && valuesFound == 2) return right;

        //    return null;
        //}

        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q,ref int valuesFound)
        //{
        //    if (root == null)
        //        return null;

        //    if (root.val.Equals(p.val) ||
        //        root.val.Equals(q.val))
        //    {
        //        valuesFound++;
        //        return root;
        //    }

        //    TreeNode left = LowestCommonAncestor(root.left, p, q,ref valuesFound);

        //    if (left != null)
        //        return left;

        //    TreeNode right = LowestCommonAncestor(root.right, p, q, ref valuesFound);

        //    if (right != null)
        //        return right;

        //    return null;
        //}

        //private void IsLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null)
        //        return;

        //    if (root.val.Equals(p.val))
        //        return;

        //    if (root.val.Equals(q.val))
        //        return;

        //    //IsLowestCommonAncestor(root.left, p, q);
        //    //    IsLowestCommonAncestor(root.right, p, q);
        //}

        //private bool IsLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null)
        //        return false;

        //    if (root.val.Equals(p.val))
        //        return true;

        //    if (root.val.Equals(q.val))
        //        return true;

        //    return IsLowestCommonAncestor(root.left, p, q) &&
        //        IsLowestCommonAncestor(root.right, p, q);
        //}

        //public (IList<int>, IList<int>) GetNodePath(TreeNode root, TreeNode p, TreeNode q, IList<int> pPath, IList<int> qPath, bool pFound, bool qFound)
        //{
        //    if (root == null)
        //        return (pPath, qPath);

        //    if (!pFound)
        //        pPath.Add(root.val);

        //    if (!qFound)
        //        qPath.Add(root.val);

        //    if (root.Equals(p))
        //    {
        //        pFound = true;
        //    }

        //    if (root.Equals(q))
        //    {
        //        qFound = true;
        //    }

        //    (IList<int> pNew, IList<int> qNew) obj;

        //    if (!pFound || !qFound)
        //    {
        //        obj = GetNodePath(root.left, p, q, pPath, qPath, pFound, qFound);
        //        obj = GetNodePath(root.right, p, q, pPath, qPath, pFound, qFound);
        //    }

        //    return (pPath, qPath);
        //}
    }
}
