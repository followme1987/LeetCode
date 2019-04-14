using Xunit;

namespace FibonacciNumberTest
{
    public class FibonacciNumberClsTest
    {
        [Theory]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,3)]
        public void FibTest(int input, int expected)
        {
            var actual = new FibonacciNumber.FibonacciNumberCls().Fib(input);

            Assert.Equal(expected, actual);
        }
    }
}
