using LeetCode.Model;

namespace LeetCode
{
    public class SumofLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            SumOfLeftLeaves(root, false, ref sum);
            return sum;
        }

        public void SumOfLeftLeaves(TreeNode root, bool isParentLeft, ref int sum)
        {
            if (root == null)
                return;

            if (isParentLeft && root.left == null && root.right == null)
                sum += root.val;

            SumOfLeftLeaves(root.left, true, ref sum);
            SumOfLeftLeaves(root.right, false, ref sum);
        }
    }
}
