using System;

namespace CommonAncestor
{
    public class CommonAncestor
    {

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val < p.val && root.val > q.val || root.val > p.val && root.val < q.val || root.val == q.val || root.val == p.val)
            {
                return root;
            }
            if (root.val < p.val && root.val < q.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return LowestCommonAncestor(root.left, p, q);
            }
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
