using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> values = new List<IList<int>>();

            RetrieveLevelOrder(root, values, 0);

            return values;
        }

        public static void RetrieveLevelOrder(TreeNode root, 
            IList<IList<int>> values, int currentOrder)
        {
            if (root == null)
                return;

            IList<int> list;

            if (values.Count == currentOrder)
            {
                list = new List<int>();
                values.Add(list);
            }
            else
                list = values[currentOrder];

            list.Add(root.val);
            RetrieveLevelOrder(root.left, values, currentOrder + 1);
            RetrieveLevelOrder(root.right, values, currentOrder + 1);
        }
    }
}
