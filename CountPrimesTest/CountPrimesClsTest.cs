using CountPrimes;
using Xunit;

namespace CountPrimesTest
{
    public class CountPrimesClsTest
    {
        [Theory]
        [TestData]
        public void CountPrimes_Test(int input, int expected)
        {
            var result = new CountPrimesCls().CountPrimes(input);

            Assert.Equal(expected, result);
        }
    }
}