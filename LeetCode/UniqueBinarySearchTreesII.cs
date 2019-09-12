using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            List<TreeNode> list = new List<TreeNode>();
            Dictionary<string, IList<TreeNode>> dp = new Dictionary<string, IList<TreeNode>>();

            for (int i = 1; i <= n; i++)
            {
                var generatedTrees = GenerateTrees(i, 1, n, dp);
                list.AddRange(generatedTrees);
            }

            return list;
        }

        private IList<TreeNode> GenerateTrees(int root, int start, int end, Dictionary<string, IList<TreeNode>> dp)
        {
            if (start == end)
                return new List<TreeNode>() { new TreeNode(root) };
            if (start > end)
                return new List<TreeNode>() { };

            string curr = $"{root}|{start}|{end}";

            if (dp.ContainsKey(curr))
                return dp[curr];

            IList<TreeNode> result = new List<TreeNode>();
            List<TreeNode> leftTrees = new List<TreeNode>();
            List<TreeNode> rightTrees = new List<TreeNode>();

            for (int i = start; i < root; i++)
                leftTrees.AddRange(GenerateTrees(i, start, root - 1, dp));

            for (int i = root + 1; i <= end; i++)
                rightTrees.AddRange(GenerateTrees(i, root + 1, end, dp));

            if (leftTrees.Count > 0 && rightTrees.Count > 0)
                for (int j = 0; j < leftTrees.Count; j++)
                {
                    for (int k = 0; k < rightTrees.Count; k++)
                    {
                        result.Add(new TreeNode(root) { left = leftTrees[j], right = rightTrees[k] });
                    }
                }
            else if (rightTrees.Count != 0)
                for (int k = 0; k < rightTrees.Count; k++)
                    result.Add(new TreeNode(root) { right = rightTrees[k] });
            else if (leftTrees.Count != 0)
                for (int j = 0; j < leftTrees.Count; j++)
                    result.Add(new TreeNode(root) { left = leftTrees[j] });
            else
                result.Add(new TreeNode(root));

            dp[curr] = result;

            return result;
        }
    }
}
