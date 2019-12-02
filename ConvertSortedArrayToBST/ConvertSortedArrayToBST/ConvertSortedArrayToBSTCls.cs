using System;

namespace ConvertSortedArrayToBST
{
    public class ConvertSortedArrayToBSTCls
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null)
            {
                return null;
            }
            return Partition(nums, 0, nums.Length - 1);
        }
        private TreeNode Partition(int[] nums, int left, int right)
        {
            if (right < left) return null;

            var mid = left + (right - left) / 2;

            var tree = new TreeNode(nums[mid]);

            tree.left = Partition(nums, left, mid - 1);

            tree.right = Partition(nums, mid + 1, right);

            return tree;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}

