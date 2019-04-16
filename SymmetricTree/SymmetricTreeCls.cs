using System;

namespace SymmetricTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class SymmetricTreeCls
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            var leftTree = root.left;
            var rightTree = root.right;

            return Compare(leftTree, rightTree);
        }

        private bool Compare(TreeNode leftTree, TreeNode rightTree)
        {
            if (leftTree == null && rightTree == null)
                return true;
            if (leftTree == null || rightTree == null)
                return false;

            return leftTree.val == rightTree.val && Compare(leftTree.left, rightTree.right) && Compare(leftTree.right, rightTree.left);
        }
    }
}
