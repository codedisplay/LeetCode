using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SmallestSubtreewithalltheDeepestNodes
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            TreeNode deepestRoot = root;
            int currentFoundDeepest = 0;
            SubtreeWithAllDeepest(root, 0, ref deepestRoot, ref currentFoundDeepest);
            return deepestRoot;
        }

        public int SubtreeWithAllDeepest(TreeNode root, int level, ref TreeNode deepestRoot, ref int currentFoundDeepest)
        {
            if (root == null)
                return level;

            level++;
            currentFoundDeepest = Math.Max(currentFoundDeepest, level);

            int leftDeepestLevel = SubtreeWithAllDeepest(root.left, level, ref deepestRoot, ref currentFoundDeepest);
            int rightDeepestLevel = SubtreeWithAllDeepest(root.right, level, ref deepestRoot, ref currentFoundDeepest);

            if (currentFoundDeepest == level)
                deepestRoot = root;
            else if (currentFoundDeepest == leftDeepestLevel && leftDeepestLevel == rightDeepestLevel)
                deepestRoot = root;

            return Math.Max(leftDeepestLevel, rightDeepestLevel);
        }

        //public int SubtreeWithAllDeepest(TreeNode root, int level, TreeNode deepestRoot, ref int currentFoundDeepest)
        //{
        //    int leftLevel = level, rightLevel = level;
        //    if (root.left != null)
        //    {
        //        leftLevel = SubtreeWithAllDeepest(root.left, level + 1, deepestRoot, ref currentFoundDeepest);
        //    }

        //    if (root.right != null)
        //    {
        //        rightLevel = SubtreeWithAllDeepest(root.right, level + 1, deepestRoot, ref currentFoundDeepest);
        //    }

        //    if (leftLevel == rightLevel)
        //    {
        //        deepestRoot = root;
        //    }

        //    return Math.Max(leftLevel,rightLevel);
        //}
    }
}
