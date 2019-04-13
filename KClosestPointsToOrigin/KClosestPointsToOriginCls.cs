using System;

namespace KClosestPointsToOrigin
{
    public class KClosestPointsToOriginCls
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var arr = new int[points.Length];

            var resultArray = new int[K][];

            for (var i = 0; i < points.Length; i++)
            {
                arr[i] = points[i][0] * points[i][0] + points[i][1] * points[i][1];
            }

            Array.Sort(arr);

            var max = arr[K - 1];

            var count = 0;

            for (var i = 0; i < points.Length; i++)
            {
                if ((points[i][0] * points[i][0]) + (points[i][1] * points[i][1]) <= max)
                {
                    resultArray[count++] = points[i];
                }
            }

            return resultArray;
        }
    }
}
