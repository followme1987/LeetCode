using System;
using Xunit;

namespace SortArrayByParityTest
{
    public class SortArrayByParityClsTest
    {
        [Fact]
        public void SortArrayByParityTest()
        {
            var input = new int[] { 3, 1, 2, 4 };
            var actual = new SortArrayByParity.SortArrayByParityCls().SortArrayByParity(input);
        
        }
    }
}
