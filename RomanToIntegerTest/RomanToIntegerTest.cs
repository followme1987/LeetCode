using Xunit;

namespace RomanToIntegerTest
{
    public class RomanToIntegerTest
    {
        private readonly RomanToInteger.RomanToInteger _ri;

        public RomanToIntegerTest()
        {
            _ri = new RomanToInteger.RomanToInteger();
        }

        [Theory]
        [TestData]
        public void RomanToInt_Test(string input, int expected)
        {
            var result = _ri.RomanToInt(input);

            Assert.Equal(expected, result);
        }
    }
}