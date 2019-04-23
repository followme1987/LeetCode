using System;
using Xunit;

namespace DIStringMatch.Test
{
    public class DIStringMatchClsTest
    {
        [Theory]
        [TestData]
        public void DiStringMatchTest(string input, int[] expected)
        {
            var actual = new DIStringMatchCls().DiStringMatch(input);

            Assert.Equal(expected, actual);
        }
    }
}
