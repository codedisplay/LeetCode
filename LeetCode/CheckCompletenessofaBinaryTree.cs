using LeetCode.Model;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class CheckCompletenessofaBinaryTree
    {

        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
                return true;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool isAncestorValid = true;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                bool isCurrentValid = true;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.left == null)
                        isCurrentValid = false;
                    else if (!isCurrentValid)
                        return false;
                    else
                        queue.Enqueue(current.left);

                    if (current.right == null)
                        isCurrentValid = false;
                    else if (!isCurrentValid)
                        return false;
                    else
                        queue.Enqueue(current.right);
                }

                if (queue.Count > 0 && !isAncestorValid)
                    return false;

                isAncestorValid = isCurrentValid;
            }

            return true;
        }
    }
}
