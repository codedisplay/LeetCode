using System;
using System.Text;
using LeetCode.Model;

namespace LeetCode
{
    public class SerializeAndDeserializeBinaryTree
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder builder = new StringBuilder();

            Serialize(root, ref builder);

            return builder.ToString().TrimEnd(',');
        }

        private void Serialize(TreeNode root, ref StringBuilder builder)
        {
            if (root == null)
            {
                builder.Append("#,");
                return;
            }

            builder.Append(root.val).Append(",");

            Serialize(root.left, ref builder);

            Serialize(root.right, ref builder);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            string[] arr = data.Split(',');
            int index = 0;

            return Deserialize(arr, ref index);
        }

        private TreeNode Deserialize(string[] arr, ref int currentIndex)
        {
            if (currentIndex >= arr.Length || arr[currentIndex] == "#")
                return null;

            TreeNode newNode = new TreeNode(Int32.Parse(arr[currentIndex]));

            currentIndex++;

            newNode.left = Deserialize(arr, ref currentIndex);

            currentIndex++;

            newNode.right = Deserialize(arr, ref currentIndex);

            return newNode;
        }

        // Your Codec object will be instantiated and called as such:
        // Codec codec = new Codec();
        // codec.deserialize(codec.serialize(root));
    }
}
