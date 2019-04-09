using System;
using Xunit;
using KClosestPointsToOrigin;

namespace KClosestPointsToOriginClsTest
{
    public class KClosestPointsToOriginClsTest
    {
        [Fact]
        public void KClosest_Test()
        {
            int[][] points = { new int[] { 1, 3 }, new int[] { -2, 2 } };

            var actual = new KClosestPointsToOriginCls().KClosest(points, 1);

            int[][] expected = { new int[] { -2, 2 } };

            Assert.Single(actual);
            Assert.Equal(expected[0][0], actual[0][0]);
            Assert.Equal(expected[0][1], actual[0][1]);
        }

        [Fact]
        public void KClosest_Test2()
        {
            int[][] points = { new int[] { 0,1}, new int[] {1,0 } };

            var actual = new KClosestPointsToOriginCls().KClosest(points, 2);

            int[][] expected = { new int[] { 0,1 }, new int[] { 1,0 } };

            Assert.Equal(2,actual.Length);
            Assert.Equal(expected[0][0], actual[0][0]);
            Assert.Equal(expected[0][1], actual[0][1]);
        }
    }
}
