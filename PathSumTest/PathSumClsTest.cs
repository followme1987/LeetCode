using System;
using PathSum;
using Xunit;

namespace PathSumTest
{
    public class PathSumClsTest
    {
        [Fact]
        public void Test1()
        {
            var tree = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(4)
                    {
                        right = new TreeNode(1)
                    }
                }
            };

            var actual = new PathSum.PathSumCls().HasPathSum(tree, 22);

            Assert.True(actual);
        }
    }
}