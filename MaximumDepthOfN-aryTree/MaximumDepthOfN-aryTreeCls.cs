using System;
using System.Collections.Generic;

namespace MaximumDepthOfN_aryTree
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node(int _val) { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class MaximumDepthOfNaryTreeCls
    {

        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;

            var list = new List<List<int>>();

            var q = new Queue<Node>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var size = q.Count;
                var listNum = new List<int>();

                for (var i = 0; i < size; i++)
                {
                    var node = q.Dequeue();
                    listNum.Add(node.val);

                    var children = node.children;

                    if (children != null)
                    {
                        foreach (var child in children)
                        {
                            q.Enqueue(child);
                        }
                    }
                }

                list.Add(listNum);
            }

            return list.Count;
        }
    }
}
