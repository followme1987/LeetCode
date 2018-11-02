using Xunit;

namespace ValidPalindromeTest
{
    public class ValidPalindromeTest
    {
        [Theory]
        [TestData]
        public void IsPalindrome_Test(string input, bool expected)
        {
            var result = new ValidPalindrome.ValidPalindrome().IsPalindrome(input);

            Assert.Equal(expected, result);
        }
    }
}