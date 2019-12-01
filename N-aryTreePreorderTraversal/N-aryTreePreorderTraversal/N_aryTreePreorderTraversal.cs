using System;
using System.Collections.Generic;

namespace N_aryTreePreorderTraversal
{
    public class N_aryTreePreorderTraversal
    {
        IList<int> result = new List<int>();
        public IList<int> Preorder(Node root)
        {
            if (root != null)
            {

                result.Add(root.val);

                if (root.children != null)
                {
                    foreach (var item in root.children)
                    {
                        Preorder(item);
                    }
                }

            }
            return result;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
