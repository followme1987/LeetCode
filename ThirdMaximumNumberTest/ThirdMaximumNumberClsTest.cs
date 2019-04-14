using System;
using Xunit;

namespace ThirdMaximumNumberTest
{
    public class ThirdMaximumNumberClsTest
    {
        [Theory]
        [TestData]
        public void ThirdMaxTest(int[] inputs, int expectedResult)
        {
            var actualResult = new ThirdMaximumNumber.ThirdMaximumNumberCls().ThirdMax(inputs);

            Assert.Equal(expectedResult,actualResult);
        }
    }
}
