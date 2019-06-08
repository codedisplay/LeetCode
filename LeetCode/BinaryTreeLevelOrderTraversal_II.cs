using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreeLevelOrderTraversal_II
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            LevelOrderBottom(root, 0, list);
            return list;
        }

        public void LevelOrderBottom(TreeNode root, int level, IList<IList<int>> list)
        {
            if (root == null)
                return;

            if (list.Count == level)
                list.Insert(0, new List<int>());//always add at top

            LevelOrderBottom(root.left, level + 1, list);
            LevelOrderBottom(root.right, level + 1, list);

            var currentLevel = list[list.Count - (level + 1)];
            currentLevel.Add(root.val);
        }
    }
}
