using System;
using Xunit;
using MaximumDepthOfN_aryTree;
using System.Collections.Generic;

namespace MaximumDepthOfNTreeTest
{
    public class MaximumDepthOfNTreeClsTest
    {
        [Fact]
        public void MaxDepthTest()
        {
            var list2 = new List<Node>
            {
                new Node(5,null),
                new Node(6,null)
            };

            var node1 = new Node(3, list2);
            var node2 = new Node(2,null);
            var node3 = new Node(4,null);

            var children = new List<Node>
            {
                node1,
                node2,
                node3
            };

            var root = new Node(1, children);

            var actual = new MaximumDepthOfNaryTreeCls().MaxDepth(root);

            Assert.Equal(3, actual);
        }
    }
}
