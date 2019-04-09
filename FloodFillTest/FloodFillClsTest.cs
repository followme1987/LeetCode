using System;
using Xunit;

namespace FloodFillTest
{
    public class FloodFillClsTest
    {
        private readonly int[][] _testData = {new int[] {1, 1, 1}, new int[] {1, 1, 0}, new int[] {1, 0, 1}};

        [Fact]
        public void FloodFill_Test()
        {
            new FloodFill.FloodFillCls().FloodFill(_testData, 1, 1, 2);

            
            Assert.Equal(2, _testData[0][0]);
            Assert.Equal(2, _testData[0][1]);
            Assert.Equal(2, _testData[0][2]);

            Assert.Equal(2, _testData[1][0]);
            Assert.Equal(2, _testData[1][1]);
            Assert.Equal(0, _testData[1][2]);

            Assert.Equal(2, _testData[2][0]);
            Assert.Equal(0, _testData[2][1]);
            Assert.Equal(1, _testData[2][2]);
        }
    }
}
