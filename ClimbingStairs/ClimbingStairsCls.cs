using System;

namespace ClimbingStairs
{
    public class ClimbingStairsCls
    {
        private int sum = 0;
        public int ClimbStairs(int n)
        {
            if (n < 0)
                return 0;

            if (n > 2)
                sum += ClimbStairs(n - 1) + ClimbStairs(n - 2);

            else if (n >= 0)
            {
                return n;
            }


            return sum;
        }
    }
}
