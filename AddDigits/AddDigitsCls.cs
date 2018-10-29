using System;

namespace AddDigits
{
    public class AddDigitsCls
    {
        public int AddDigits(int num)
        {
            if (num / 10 == 0)
                return num;

            int sum;

            do
            {
                sum = 0;
                var newNum = num;
                for (var i = 0; i < num.ToString().Length; i++)
                {
                    var n = newNum % 10;
                    newNum = newNum / 10;
                    sum += n;
                }

                num = sum;
            } while (sum / 10 >= 1);

            return sum;
        }
    }
}
