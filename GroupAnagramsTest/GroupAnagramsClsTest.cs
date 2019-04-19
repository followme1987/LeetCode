using System;
using Xunit;

namespace GroupAnagramsTest
{
    public class GroupAnagramsClsTest
    {
        [Fact]
        public void GroupAnagrams_Test()
        {
            var actual = new GroupAnagrams.GroupAnagramsCls().GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            Assert.Equal(3, actual.Count);
        }
    }
}
