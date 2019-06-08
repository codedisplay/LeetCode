using LeetCode.Model;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BinaryTree_Paths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();

            StringBuilder path = new StringBuilder($"{root?.val}");

            if (root != null && root.left == null && root.right == null)
                list.Add(path.ToString());

            BinaryTreePaths(root?.left, path, ref list);
            BinaryTreePaths(root?.right, path, ref list);

            return list;
        }

        public void BinaryTreePaths(TreeNode root, StringBuilder path, ref IList<string> list)
        {
            if (root == null)
                return;

            var currentAppendText = $"->{root.val}";

            path.Append(currentAppendText);

            if (root.left == null && root.right == null)
                list.Add(path.ToString());

            BinaryTreePaths(root.left, path, ref list);
            BinaryTreePaths(root.right, path, ref list);

            path.Remove(path.Length - currentAppendText.Length, currentAppendText.Length);
        }
    }
}
