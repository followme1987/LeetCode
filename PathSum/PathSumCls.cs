namespace PathSum
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class PathSumCls
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null && root.val == sum)
                return true;
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}