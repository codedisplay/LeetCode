using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ConstructBinarySearchTreefromPreorderTraversal
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            int counter = 0;
            return BstFromPreorder(preorder, int.MinValue, int.MaxValue, ref counter);
        }

        public TreeNode BstFromPreorder(int[] preorder, int min, int max, ref int counter)
        {
            if (counter == preorder.Length)
                return null;

            var curr = preorder[counter];
            if (curr < min || curr > max)
                return null;

            TreeNode node = new TreeNode(curr);
            counter++;

            node.left = BstFromPreorder(preorder, min, curr, ref counter);

            node.right = BstFromPreorder(preorder, curr, max, ref counter);

            return node;
        }
    }
}
