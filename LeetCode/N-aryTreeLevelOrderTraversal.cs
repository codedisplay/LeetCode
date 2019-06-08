using System.Collections.Generic;

namespace LeetCode.N_aryTreeLevelOrderTraversal
{
    public class N_aryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            LevelOrder(root, 0, list);
            return list;
        }

        public void LevelOrder(Node root, int level, IList<IList<int>> list)
        {
            if (root == null)
                return;

            if (level == list.Count)
                list.Add(new List<int>());

            var currentLevelList = list[level];
            currentLevelList.Add(root.val);

            foreach (var item in root.children)
                LevelOrder(item, level + 1, list);
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
