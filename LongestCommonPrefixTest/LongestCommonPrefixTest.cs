using LongestCommonPrefix;
using Xunit;

namespace LongestCommonPrefixTest
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void LongestCommonPrefix_Test()
        {
            var result = new LongestCommonPrefixCls().LongestCommonPrefix(new[] {"aa", "a"});

            Assert.Equal("", result);
        }
    }
}