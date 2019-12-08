using System;
using Xunit;

namespace ValidAnagram.Test
{
    public class ValidAnagramTest
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("ab", "a", false)]
        [InlineData("aacc", "ccac", false)]
        public void Test1(string s1, string s2, bool expected)
        {
            var actual = new ValidAnagram.ValidAnagramCls().IsAnagram(s1, s2);
            Assert.Equal(expected, actual);
        }
    }
}
