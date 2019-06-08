using LeetCode.Model;
using System;

namespace LeetCode
{
    public class RangeSumofBST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            RangeSumBST(root, L, R, ref sum);
            return sum;
        }

        public bool RangeSumBST(TreeNode root, int L, int R, ref int sum)
        {
            if (root == null)
                return false;

            bool isFinished = RangeSumBST(root.left, L, R, ref sum);

            if (isFinished)
                return true;

            if (root.val >= L && root.val <= R)
                sum += root.val;

            if (root.val == Math.Max(L, R))
                return true;

            isFinished = RangeSumBST(root.right, L, R, ref sum);

            return isFinished;
        }
    }
}
