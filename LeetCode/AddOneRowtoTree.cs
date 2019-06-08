using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class AddOneRowtoTree
    {
        public TreeNode AddOneRow(TreeNode root, int v, int d)
        {
            if (root == null)
                return null;
            else if (d == 1)
                return new TreeNode(v) { left = root };

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int depth = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                if (depth + 1 == d)
                {
                    for (int i = 0; i < size; i++)
                    {
                        TreeNode current = queue.Dequeue();

                        TreeNode left = current.left;
                        current.left = new TreeNode(v) { left = left };

                        TreeNode right = current.right;
                        current.right = new TreeNode(v) { right = right };
                    }

                    return root;
                }

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }

                depth++;
            }

            return root;
        }
    }
}
