using LeetCode.Model;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null) return list;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            bool isReverseOrder = false;

            stack.Push(root);

            while (stack.Any())
            {
                isReverseOrder = !isReverseOrder;
                stack = ZigzagLevelOrderHelper(isReverseOrder, stack, list);
            }

            return list;
        }

        private static Stack<TreeNode> ZigzagLevelOrderHelper(bool isReverseOrder, Stack<TreeNode> stack, IList<IList<int>> list)
        {
            List<int> listItem = new List<int>();
            Stack<TreeNode> newStack = new Stack<TreeNode>();

            while (stack.Any())
            {
                var node = stack.Pop();
                listItem.Add(node.val);

                if (isReverseOrder)
                {
                    if (node.left != null)
                        newStack.Push(node.left);

                    if (node.right != null)
                        newStack.Push(node.right);
                }
                else
                {
                    if (node.right != null)
                        newStack.Push(node.right);

                    if (node.left != null)
                        newStack.Push(node.left);
                }
            }

            list.Add(listItem);
            return newStack;
        }
    }
}
