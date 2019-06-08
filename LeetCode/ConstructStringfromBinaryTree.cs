using LeetCode.Model;
using System.Text;

namespace LeetCode
{
    public class ConstructStringfromBinaryTree
    {
        public string Tree2str(TreeNode t)
        {
            if (t == null)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            Tree2str(t, sb);
            return sb.ToString();
        }

        public void Tree2str(TreeNode root, StringBuilder sb)
        {
            sb.Append($"{root.val}");

            if (root.left == null && root.right == null)
                return;

            if (root.left != null)
            {
                sb.Append("(");
                Tree2str(root.left, sb);
                sb.Append(")");
            }

            if (root.right != null)
            {
                if (root.left == null) sb.Append("()");

                sb.Append("(");
                Tree2str(root.right, sb);
                sb.Append(")");
            }
        }
    }
}
