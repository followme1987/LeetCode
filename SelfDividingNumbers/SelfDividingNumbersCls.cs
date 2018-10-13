using System.Collections.Generic;

namespace SelfDividingNumbers
{
    public class SelfDividingNumbersCls
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();
            for (var i = left; i <= right; i++)
                if (IsSelfDrivenNum(i))
                    result.Add(i);

            return result;
        }

        private static bool IsSelfDrivenNum(int origin)
        {
            var n = origin;

            while (n > 0)
            {
                var temp = n % 10;

                if (temp == 0 || origin % temp != 0)
                    return false;

                n = n / 10;
            }

            return true;
        }
    }
}