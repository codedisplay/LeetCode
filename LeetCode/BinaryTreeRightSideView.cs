using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreeRightSideView
    {
        //TODO: can be implemented without queues, so that run time is improved
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> list = new List<int>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current == null)
                        continue;

                    if (level == list.Count)
                        list.Add(current.val);
                    else
                        list[level] = current.val;

                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);
                }

                level++;
            }

            return list;
        }
    }
}
