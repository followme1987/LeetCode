using System;

namespace ClimbingStairs
{
    public class ClimbingStairsCls
    {

        public int ClimbStairs(int n)
        {

            if (n >= 0 && n <= 2)
                return n;
            var arr = new int[n + 1];
            arr[1] = 1;
            arr[2] = 2;

            for (var i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
            //if (n >= 0 && n <= 2)
            //{
            //    return n;
            //}


            //return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
