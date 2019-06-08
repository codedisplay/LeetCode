using LeetCode.Model;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class HouseRobberIII
    {
        public int Rob(TreeNode root)
        {
            if (root == null)
                return 0;

            int firstWay = 0, secondWay = 0;
            bool isFirstWay = false;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                int currentSum = 0;
                isFirstWay = !isFirstWay;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    currentSum += current.val;

                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }

                if (isFirstWay)
                    firstWay += currentSum;
                else
                    secondWay += currentSum;
            }

            return Math.Max(firstWay, secondWay);
        }
    }
}
