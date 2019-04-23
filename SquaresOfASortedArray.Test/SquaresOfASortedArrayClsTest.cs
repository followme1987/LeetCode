using System;
using Xunit;

namespace SquaresOfASortedArray.Test
{
    public class SquaresOfASortedArrayClsTest
    {
        [Theory]
        [TestData]
        public void SortedSquaresTest(int[] inputs, int[] expected)
        {
            var actual = new SquaresOfASortedArrayCls().SortedSquares(inputs);

            Assert.Equal(expected, actual);
        }
    }
}
