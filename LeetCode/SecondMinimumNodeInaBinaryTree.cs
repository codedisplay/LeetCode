using LeetCode.Model;
using System;

namespace LeetCode
{
    public class SecondMinimumNodeInaBinaryTree
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null)
                return -1;

            int val = FindMinimumValue(root, root.val);

            return val == root.val ? -1 : val;
        }

        public int FindMinimumValue(TreeNode root, int prevVal)
        {
            if (root == null)
                return prevVal;

            if (root.val > prevVal)
                return root.val;

            int left = FindMinimumValue(root.left, root.val);
            int right = FindMinimumValue(root.right, root.val);

            return (left != prevVal && right != prevVal)
                ? Math.Min(left, right)
                : left != prevVal 
                    ? left : right;
        }

        //public int FindMinimumValue(TreeNode root)
        //{
        //    if (root == null)
        //        return -1;

        //    if (root.left == null && root.right == null)
        //        return root.val;

        //    int left = -1;
        //    if (root.left != null)
        //    {
        //        if (root.left.val != root.val)
        //            left = root.left.val;
        //        else
        //            left = FindMinimumValue(root.left);
        //    }

        //    int right = -1;
        //    if (root.right != null)
        //    {
        //        if (root.right.val != root.val)
        //            right = root.right.val;
        //        else
        //            right = FindMinimumValue(root.right);
        //    }

        //    return left == -1 ? right : Math.Min(left, right);
        //}

        //public int FindSecondMinimumValue(TreeNode root)
        //{
        //    Queue<TreeNode> queue = new Queue<TreeNode>();

        //    if (root == null)
        //        return -1;

        //    queue.Enqueue(root);
        //    int firstValue = root.val;
        //    int currentLowest = -1;
        //    while (queue.Count > 0)
        //    {
        //        int size = queue.Count;

        //        for (int i = 0; i < size; i++)
        //        {
        //            TreeNode current = queue.Dequeue();

        //            //if (current.val != firstValue)
        //            //{
        //            //    currentLowest = Math.Min(currentLowest,current.val);

        //            //    return current.val;
        //            //}

        //            if (current.left != null)
        //            {
        //                if (current.left.val == firstValue)
        //                {
        //                    int val = FindSecondMinimumValue(current.left);
        //                }

        //                queue.Enqueue(current.left);
        //            }

        //            if (current.right != null) queue.Enqueue(current.right);

        //        }
        //    }

        //    return -1;
        //}
    }
}
