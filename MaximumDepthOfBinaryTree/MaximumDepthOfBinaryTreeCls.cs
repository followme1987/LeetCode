using System;

namespace MaximumDepthOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class MaximumDepthOfBinaryTreeCls
    {

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var maxLeft = MaxDepth(root.left);
            var maxRight = MaxDepth(root.right);

            return Math.Max(maxLeft, maxRight) + 1;
        }
    }
}
