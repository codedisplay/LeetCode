using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaximumLevelSumofaBinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            int smallestLevel = 0;
            int currMax = int.MinValue;

            if (root == null)
                return smallestLevel;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int depth = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                int currSum = 0;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    currSum += current.val;

                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }

                if (currSum > currMax)
                {
                    currMax = currSum;
                    smallestLevel = depth;
                }

                depth++;
            }

            return smallestLevel;
        }
    }
}
