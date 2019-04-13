using System;
using Xunit;

namespace RemoveDuplicatesFromSortedArrayTest
{
    public class RmoveDuplicatesFromSortedArrayClsTest
    {
        [Theory]
        [TestData]
        public void RemoveDuplicatesTest(int[] inputs, int expected)
        {
            var actualLength = new RemoveDuplicatesFromSortedArray.RmoveDuplicatesFromSortedArrayCls().RemoveDuplicates(inputs);

            Assert.Equal(expected, actualLength);
        }
    }
}
