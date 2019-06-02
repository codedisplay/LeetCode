using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            IList<TreeNode> list = new List<TreeNode>();

            GenerateTrees(0, n, list);

            return list;
        }

        private IList<TreeNode> GenerateTrees(int start, int end, IList<TreeNode> list)
        {
            IList<TreeNode> tree = new List<TreeNode>();

            for (int i = start; i <= end; i++)
            {
                GenerateTrees(start + 1, end, list);
            }

            return tree;
        }
    }
}
