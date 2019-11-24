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
            {
                return new List<IList<int>>();
            }
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var resultList = new List<IList<int>>();

            while (q.Count > 0)
            {
                var level = new List<int>();

                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var treeNode = q.Dequeue();
                    level.Add(treeNode.val);
                    if (treeNode.left != null)
                    {
                        q.Enqueue(treeNode.left);
                    }
                    if (treeNode.right != null)
                    {
                        q.Enqueue(treeNode.right);
                    }
                }
                resultList.Add(level);
            }
            resultList.Reverse();
            return resultList;
        }
    }
}





