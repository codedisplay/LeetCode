using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class PathSumII
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<int> seq = new List<int>();

            PathSum(root, sum, seq, ref list);

            return list;
        }

        public void PathSum(TreeNode root, int sum, List<int> seq, ref IList<IList<int>> list)
        {
            if (root == null)
                return;

            seq.Add(root.val);

            if (root.val == sum && root.left == null && root.right == null)
                list.Add(new List<int>(seq));

            PathSum(root.left, sum - root.val, seq, ref list);
            PathSum(root.right, sum - root.val, seq, ref list);

            seq.RemoveAt(seq.Count - 1);
        }
    }
}
