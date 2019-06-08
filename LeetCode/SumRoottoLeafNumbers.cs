using LeetCode.Model;

namespace LeetCode
{
    public class SumRoottoLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
                return 0;
            
            int sum = 0;

            SumNumbers(root, 0, ref sum);

            return sum;
        }

        public void SumNumbers(TreeNode root, int prevSum, ref int totalSum)
        {
            int currentSum = prevSum * 10 + root.val;

            if (root.left == null && root.right == null)
                totalSum += currentSum;

            if (root.left != null)
                SumNumbers(root.left, currentSum, ref totalSum);

            if (root.right != null)
                SumNumbers(root.right, currentSum, ref totalSum);
        }
    }
}
