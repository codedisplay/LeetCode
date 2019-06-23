using LeetCode.Model;
using System;

namespace LeetCode
{
    public class HouseRobberIII
    {
        public int Rob(TreeNode root)
        {
            return Math.Max(RobCurrent(root), RobNext(root));
        }

        public int RobCurrent(TreeNode root)
        {
            if (root == null)
                return 0;

            return root.val + RobNext(root.left) + RobNext(root.right);
        }

        public int RobNext(TreeNode root)
        {
            if (root == null)
                return 0;

            return Rob(root.left) + Rob(root.right);
        }

        //public int Rob(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;

        //    int alternateSum = Rob(root.left) + Rob(root.right);
        //    int currentSum = root.val + RobNext(root.left) + RobNext(root.right);

        //    return Math.Max(alternateSum,currentSum);
        //}

        //public int RobNext(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;

        //    int leftSum = Math.Max(Rob(root.left), RobNext(root.left));
        //    int rightSum = Math.Max(Rob(root.right), RobNext(root.right)); ;

        //    return leftSum + rightSum;
        //}

        //public int Rob(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;

        //    int firstWay = 0, secondWay = 0;
        //    bool isFirstWay = false;
        //    Queue<TreeNode> queue = new Queue<TreeNode>();
        //    queue.Enqueue(root);

        //    while (queue.Count > 0)
        //    {
        //        int size = queue.Count;
        //        int currentSum = 0;
        //        isFirstWay = !isFirstWay;

        //        for (int i = 0; i < size; i++)
        //        {
        //            TreeNode current = queue.Dequeue();
        //            currentSum += current.val;

        //            if (current.left != null) queue.Enqueue(current.left);
        //            if (current.right != null) queue.Enqueue(current.right);
        //        }

        //        if (isFirstWay)
        //            firstWay += currentSum;
        //        else
        //            secondWay += currentSum;
        //    }

        //    return Math.Max(firstWay, secondWay);
        //}
    }
}
