using System;
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

        [Fact]
        public void MaxSubArray()
        {
           var result = _maxSubArr.MaxSubArray(new[] { -2, -1 });

            Assert.Equal(6,result);
        }
    }
}
