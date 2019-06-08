using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class AverageofLevelsinBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> values = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count, count = 0;
                double sum = 0;

                for (int i = 0; i < size; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode == null)
                        continue;

                    sum += currentNode.val;
                    count++;

                    queue.Enqueue(currentNode.left);
                    queue.Enqueue(currentNode.right);
                }

                if (count != 0)
                    values.Add(sum/count);
            }

            return values;
        }
    }
}
