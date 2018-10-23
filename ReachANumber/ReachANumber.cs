using System;

namespace ReachANumber
{
    public class ReachANumber
    {
        public int ReachNumber(int target)
        {
            var sum = 0;
            var step = 0;

            while (sum < Math.Abs(target))
            {
                step++;
                sum += step;
            }

            if (sum == target || (sum - target) % 2 == 0)
                return step;

            while (true)
            {
                step++;
                sum += step;
                if ((sum - target) % 2 == 0) return step;
            }
        }
    }
}