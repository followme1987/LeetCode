using System;
using Xunit;
using RemoveElement;

namespace RemoveElementTest
{
    public class RemoveElementClsTest
    {
        [Fact]
        public void RemoveElementTest()
        {
        
            var actual = new RemoveElementCls().RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            Assert.Equal(5, actual);
        }
    }
}
