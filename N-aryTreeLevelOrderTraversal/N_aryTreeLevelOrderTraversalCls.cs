using System;
using System.Collections.Generic;

namespace N_aryTreeLevelOrderTraversal
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class N_aryTreeLevelOrderTraversalCls
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null)
                return new List<IList<int>>();

            var resultList = new List<IList<int>>();
            var queue = new Queue<Node>();

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var list = new List<int>();

                var queueSize = queue.Count;

                for (var i = 0; i < queueSize; i++)
                {
                    var node = queue.Dequeue();

                    list.Add(node.val);

                    foreach (var n in node.children)
                    {
                        queue.Enqueue(n);
                    }
                }

                resultList.Add(list);
            }

            return resultList;
        }      
    }
}
