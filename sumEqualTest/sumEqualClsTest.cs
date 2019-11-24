using Xunit;

namespace SumEqualTest
{
    public class SumEqualClsTest
    {
        [Theory]
        [InlineData(new int[] { 1, 4, 2, 5 }, 2)]
        [InlineData(new int[] { 2, 3, 4, 1, 4, 5 }, 1)]
        public void GetSumEqualTest(int[] input, int expected)
        {
            var actual = new SumEqual.SumEqualCls().GetSumEqual(input);

            Assert.Equal(expected, actual);
        }
    }
}
