using LeetCode.Model;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class FindLargestValueinEachTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            IList<int> list = new List<int>();

            if (root == null)
                return list;

            Queue<TreeNode> outer = new Queue<TreeNode>();
            outer.Enqueue(root);

            while (outer.Count > 0)
            {
                Queue<TreeNode> inner = new Queue<TreeNode>();
                int currentMax = int.MinValue;

                while (outer.Count > 0)
                {
                    TreeNode current = outer.Dequeue();
                    currentMax = Math.Max(currentMax, current.val);

                    if (current.left != null)
                        inner.Enqueue(current.left);
                    if (current.right != null)
                        inner.Enqueue(current.right);
                }

                list.Add(currentMax);
                outer = inner;
            }

            return list;
        }
    }
}
