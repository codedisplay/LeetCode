using LeetCode.Model;

namespace LeetCode
{
    public class ConvertBSTtoGreaterTree
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            int sum = 0;
            ConvertBST(root, ref sum);
            return root;
        }

        public void ConvertBST(TreeNode root, ref int sumFromRight)
        {
            if (root == null)
                return;

            ConvertBST(root.right, ref sumFromRight);

            sumFromRight += root.val;
            root.val = sumFromRight;

            ConvertBST(root.left, ref sumFromRight);
        }
    }
}
