using LeetCode.Model;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                keyValuePairs[nums[i]] = i;
            }
            Array.Sort(nums);

            TreeNode node = new TreeNode(nums[nums.Length - 1]);

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                TreeNode current = node;
                TreeNode latest = new TreeNode(nums[i]);

                while (current.left != latest && current.right != latest)
                {
                    if (keyValuePairs[nums[i]] > keyValuePairs[current.val])// right child
                    {
                        if (current.right != null)
                            current = current.right;
                        else
                            current.right = latest;
                    }
                    else
                    {
                        if (current.left != null)
                            current = current.left;
                        else
                            current.left = latest;
                    }
                }
            }

            return node;
        }

        //if (keyValuePairs[nums[i]] > keyValuePairs[node.val])// right child
        //{
        //    if (keyValuePairs[nums[i]] > keyValuePairs[right.val])//right side of right child
        //    {
        //        right.right = current;
        //    }
        //    else
        //    {
        //        right.left = current;
        //    }

        //    right = current;
        //}
        //else
        //{
        //    if (keyValuePairs[nums[i]] > keyValuePairs[left.val])//rigth side of left child
        //    {
        //        left.right = current;
        //    }
        //    else
        //    {
        //        left.left = current;
        //    }

        //    left = current;
        //}

        //public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return null;

        //    TreeNode root = new TreeNode(nums[0]);
        //    TreeNode currentRootNode = null;
        //    TreeNode prev = null;

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        TreeNode current = new TreeNode(nums[i]);

        //        if (currentRootNode == null)
        //        {
        //            currentRootNode = current;
        //            prev = current;
        //            continue;
        //        }

        //        if (root.val > nums[i])
        //        {
        //            if (currentRootNode.val > nums[i])
        //            {
        //                if (prev.val > nums[i])
        //                {
        //                    prev.right = current;
        //                }
        //                else
        //                {
        //                    prev.left = current;
        //                }
        //            }
        //            else
        //            {

        //            }
        //        }
        //        else
        //        {
        //            current.left = root;
        //            root = current;
        //            currentRootNode = null;
        //        }

        //        prev = current;
        //    }

        //    return root;
        //}

    }
}
