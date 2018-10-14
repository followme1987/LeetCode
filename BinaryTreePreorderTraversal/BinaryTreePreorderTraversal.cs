using System.Collections.Generic;

namespace BinaryTreePreorderTraversal
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

    public class BinaryTreePreorderTraversal
    {
        private readonly IList<int> returnedList = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root != null)
            {
                returnedList.Add(root.val);

                if (root.left != null) PreorderTraversal(root.left);
                if (root.right != null) PreorderTraversal(root.right);
            }

            return returnedList;
        }
    }
}