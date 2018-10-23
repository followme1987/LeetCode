using MaxmiumSubarray;
using Xunit;

namespace MaxmiumSubarrayTest
{
    public class MaxmiumSubarrayTest
    {
        private readonly MaxmiumSubarray.MaxmiumSubarray _maxSubArr;

        public MaxmiumSubarrayTest()
        {
            _maxSubArr = new MaxmiumSubarray.MaxmiumSubarray();
        }

        [Theory]
        [TestData]
        public void MaxSubArray(int[] input, int expected)
        {
            var result = _maxSubArr.MaxSubArray(input);

            Assert.Equal(expected, result);
        }
    }
}