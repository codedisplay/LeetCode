using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            List<int> seq = new List<int>() { 0 };

            return PathSum(root, sum, 0, seq);
        }

        public int PathSum(TreeNode root, int sum, int previousSum, List<int> additionSeq)
        {
            if (root == null)
                return 0;

            int count = 0;
            previousSum += root.val;
            additionSeq.Add(previousSum);

            //TODO: improve runtime by modifying this to Dictionary
            for (int i = 0; i < additionSeq.Count-1; i++)
            {
                if (additionSeq[additionSeq.Count - 1] - additionSeq[i] == sum)
                    count++;
            }

            count += PathSum(root.left, sum, previousSum, additionSeq) + PathSum(root.right, sum, previousSum, additionSeq);

            additionSeq.RemoveAt(additionSeq.Count - 1);

            return count;
        }
    }
}
