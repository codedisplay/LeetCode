using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode.Utils
{
    public class Helpers
    {
        public static TreeNode GenerateBinaryTree(int?[] arr)
        {
            if (arr.Length == 0 && arr[0] != null)
                return null;

            TreeNode node = new TreeNode(arr[0].Value);
            int currentIndex = 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(node);
            currentIndex++;

            while (currentIndex < arr.Length)
            {
                var current = queue.Dequeue();
                if (arr[currentIndex] != null)
                {
                    current.left = new TreeNode(arr[currentIndex].Value);
                    queue.Enqueue(current.left);
                }
                currentIndex++;

                if (currentIndex < arr.Length)
                {
                    if (arr[currentIndex] != null)
                    {
                        current.right = new TreeNode(arr[currentIndex].Value);
                        queue.Enqueue(current.right);
                    }

                    currentIndex++;
                }
            }

            return node;
        }
    }
}
