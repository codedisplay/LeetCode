using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode
{
    public class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            InorderTraversal(root, values);

            return values;
        }

        public static void InorderTraversal(TreeNode root, IList<int> values)
        {
            if (root == null)
                return;

            InorderTraversal(root.left, values);
            values.Add(root.val);
            InorderTraversal(root.right, values);
        }
    }
}
