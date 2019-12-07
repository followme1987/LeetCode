namespace ValidateBST
{
    public class ValidateBSTCls
    {
        public bool IsValidBST(TreeNode root)
        {
            return CheckBST(root, long.MinValue, long.MaxValue);
        }

        private bool CheckBST(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;
            if (root.val > min && root.val < max)
            {
                if (root.left != null && root.left.val >= root.val)
                    return false;
                if (root.right != null && root.right.val <= root.val)
                    return false;
                return CheckBST(root.left, min, root.val) && CheckBST(root.right, root.val, max);
            }
            return false;
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
