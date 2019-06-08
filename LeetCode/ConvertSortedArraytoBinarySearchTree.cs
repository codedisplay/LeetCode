using LeetCode.Model;

namespace LeetCode
{
    public class ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBST(int[] nums, int start, int end)
        {
            if (start > end)
                return null;

            if (start == end)
                return new TreeNode(nums[start]);

            int rootIndex = start + (end - start + 1) / 2;

            var left = SortedArrayToBST(nums, start, rootIndex - 1);
            var right = SortedArrayToBST(nums, rootIndex + 1, end);

            TreeNode currentRoot = new TreeNode(nums[rootIndex])
            {
                left = left,
                right = right
            };

            return currentRoot;
        }
    }
}
