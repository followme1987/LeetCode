using System;
using Xunit;

namespace ReverseStringTest
{
    public class ReverseStringClsTest
    {
        [Theory]
        [TestData]
        public void ReverseStringTest(char[] input)
        {
            var actual = input;
            new ReverseString.ReverseStringCls().ReverseString(input);
            Assert.Equal(actual, input);
        }
    }
}
