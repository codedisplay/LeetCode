using LeetCode.Model;
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

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                }
            }

            return true;
        }
    }
}
