using LeetCode.Model;

namespace LeetCode
{
    public class KthSmallestElementinaBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            int value = 0, index = 0;
            KthSmallest(root, k, ref index, ref value);
            return value;
        }

        public void KthSmallest(TreeNode root, int lookupIndex, ref int currentIndex, ref int value)
        {
            if (root == null || currentIndex >= lookupIndex)
                return;

            KthSmallest(root.left, lookupIndex, ref currentIndex, ref value);

            currentIndex++;

            if (currentIndex == lookupIndex)
                value = root.val;

            KthSmallest(root.right, lookupIndex, ref currentIndex, ref value);
        }
    }
}
