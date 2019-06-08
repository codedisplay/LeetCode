using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            int currentVal = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    currentVal = current.val;

                    if (current.right != null) queue.Enqueue(current.right);
                    if (current.left != null) queue.Enqueue(current.left);
                }
            }

            return currentVal;
        }
    }
}
