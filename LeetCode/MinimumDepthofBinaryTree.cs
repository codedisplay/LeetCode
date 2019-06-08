using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class MinimumDepthofBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int level = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                level++;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.left == null && current.right == null)
                        return level;
                    if (current.left != null)
                        queue.Enqueue(current.left);
                    if (current.right != null)
                        queue.Enqueue(current.right);
                }
            }

            return level;
        }
    }
}
