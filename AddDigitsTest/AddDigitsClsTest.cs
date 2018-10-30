using AddDigits;
using Xunit;

namespace AddDigitsTest
{
    public class AddDigitsClsTest
    {
        [Fact]
        public void AddDigits_Test()
        {
            var result = new AddDigitsCls().AddDigits(638);

            Assert.Equal(8, result);
        }
    }
}