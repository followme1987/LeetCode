using System.Collections;

namespace CountPrimes
{
    public class CountPrimesCls
    {
        public int CountPrimes(int n)
        {
            if (n <= 1)
                return 0;

            var map = new BitArray(n, true);
            var count = 0;

            for (var i = 2; i < n; i++)
            {
                if (map.Get(i))
                    count++;

                for (var j = 2; i * j < n; j++) map[i * j] = false;
            }

            return count;
        }
    }
}