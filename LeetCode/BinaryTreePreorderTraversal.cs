using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode
{
    public class BinaryTreePreorderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            PreorderTraversal(root, values);

            return values;
        }

        public static void PreorderTraversal(TreeNode root, IList<int> values)
        {
            if (root == null)
                return;

            values.Add(root.val);

            PreorderTraversal(root.left, values);
            PreorderTraversal(root.right, values);
        }
    }
}
