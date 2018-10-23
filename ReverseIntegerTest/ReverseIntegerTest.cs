using Xunit;

namespace ReverseIntegerTest
{
    public class ReverseIntegerTest
    {
        private readonly ReverseInteger.ReverseInteger _reverseInteger;

        public ReverseIntegerTest()
        {
            _reverseInteger = new ReverseInteger.ReverseInteger();
        }

        [Theory]
        [TestData]
        public void Reverse(int input, int expected)
        {
            var returned = _reverseInteger.Reverse(input);

            Assert.Equal(expected, returned);
        }
    }
}