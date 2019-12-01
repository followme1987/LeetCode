using System;
using System.Collections.Generic;
using Xunit;

namespace N_aryTreePreorderTraversalTest
{
    public class N_aryTreePreorderTraversalTest
    {
        [Fact]
        public void PreorderTest()
        {
            var tree = new N_aryTreePreorderTraversal.Node()
            {
                val = 1,
                children = new List<N_aryTreePreorderTraversal.Node>()
                {
                    {
                        new N_aryTreePreorderTraversal.Node()
                        {
                            val = 3,
                            children = new List<N_aryTreePreorderTraversal.Node>()
                            {
                                {
                                    new N_aryTreePreorderTraversal.Node()
                                    {
                                        val = 5,
                                        children = null

                                    }
                                },
                                {
                                    new N_aryTreePreorderTraversal.Node()
                                    {
                                        val = 6,
                                        children = null
                                    }
                                }
                            }
                        }
                    },
                    {
                        new N_aryTreePreorderTraversal.Node()
                        {
                            val = 2,
                            children = null
                        }
                    },
                    {
                        new N_aryTreePreorderTraversal.Node()
                        {
                            val = 4,
                            children = null
                        }
                    }
                }
            };
            var actual = new N_aryTreePreorderTraversal.N_aryTreePreorderTraversal().Preorder(tree);
            var expected = new List<int>()
            {
                1,3,5,6,2,4
            };

            Assert.Equal(expected, actual);
        }
    }
}
