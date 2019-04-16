using System;
using Xunit;
using SameTree;
namespace SameTreeTest
{
    public class SameTreeClsTest
    {
        [Fact]
        public void IsSameTreeTest()
        {
            var root = new TreeNode(1);
            var left = new TreeNode(2);

            root.left = left;
            root.right = null;

            var root2 = new TreeNode(1);
            var right = new TreeNode(2);

            root2.left = null;
            root2.right = right;

            var actual = new SameTreeCls().IsSameTree(root, root2);

            Assert.False(actual);
        }

        [Fact]
        public void IsSameTreeTest2()
        {
            var root = new TreeNode(1);
            var left = new TreeNode(2);
            var right = new TreeNode(3);
            root.left = left;
            root.right = right;

            var root2 = new TreeNode(1);
            var left2 = new TreeNode(2);
            var right2 = new TreeNode(3);

            root2.left = left2;
            root2.right = right2;

            var actual = new SameTreeCls().IsSameTree(root, root2);

            Assert.True(actual);
        }
    }
}
