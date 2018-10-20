using System;
using Xunit;

namespace XUnitTestProject2
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void IsPalindrome_Test()
        {
            var result = new PalindromeNumber.PalindromeNumber().IsPalindrome(121);

            Assert.True(result);
        }
    }
}
