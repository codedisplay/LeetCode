using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class CousinsinBinaryTree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null || root.val == x || root.val == y)
                return false;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                bool isValueFound = false;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    bool isLeftFound = false, isRightFound = false;

                    if (current.left != null)
                    {
                        isLeftFound = current.left.val == x || current.left.val == y;
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        isRightFound = current.right.val == x || current.right.val == y;
                        queue.Enqueue(current.right);
                    }

                    if (isLeftFound && isRightFound) return false;

                    if (isLeftFound || isRightFound)
                        if (isValueFound)
                            return true;
                        else
                            isValueFound = true;
                }
            }

            return false;
        }
    }
}
