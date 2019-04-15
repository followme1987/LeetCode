using System;
using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversalII
{
    public class BinaryTreeLevelOrderTraversalIICls
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            var q = new Queue<TreeNode>();

            var result = new List<IList<int>>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var level = new List<int>();

                var queueSize = q.Count;

                for(var i = 0; i < queueSize; i++)
                {
                    var n = q.Dequeue();

                    level.Add(n.val);

                    if (n.left != null)
                        q.Enqueue(n.left);
                    if (n.right != null)
                        q.Enqueue(n.right);
                }

                result.Add(level);
            }

            result.Reverse();

            return result;
        }
    }
}
