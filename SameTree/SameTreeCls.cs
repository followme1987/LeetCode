using System;
using System.Collections.Generic;

namespace SameTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class SameTreeCls
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return CompareTrees(p, q);
        }

        private bool CompareTrees(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null && q != null)
                return false;
            if (p != null && q == null)
                return false;
           

            return p.val == q.val && CompareTrees(p.left, q.left) && CompareTrees(p.right, q.right);
        }
    }
}
