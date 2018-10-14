namespace MergeTwoBinaryTrees
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;

            t1.val += t2.val;

            t1.right = MergeTrees(t1.right, t2.right);
            t1.left = MergeTrees(t1.left, t2.left);

            return t1;
        }

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
    }
}