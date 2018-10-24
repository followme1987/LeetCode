using ClimbingStairs;
using Xunit;

namespace ClimbingStairsTest
{
    public class ClimbingStairsClsTest
    {
        [Theory]
        [TestData]
        public void ClimbStairs_Test(int input, int expected)
        {
            var result = new ClimbingStairsCls().ClimbStairs(input);

            Assert.Equal(expected, result);
        }
    }
}