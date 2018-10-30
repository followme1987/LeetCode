using Xunit;

namespace IsomorphicStringsTest
{
    public class IsomorphicStringsClsTest
    {
        [Theory]
        [TestData]
        public void IsIsomorphic_Test(string @base, string input, bool expected)
        {
            var result = new IsomorphicStrings.IsomorphicStrings().IsIsomorphic(@base, input);

            Assert.Equal(expected, result);
        }
    }
}