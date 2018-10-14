using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzCls
    {
        public IList<string> FizzBuzz(int n)
        {

            var result = new List<string>();

            while (n > 0)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    result.Add("Fizz");
                }

                else if (n % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(n.ToString());
                }

                n--;
            }

            result.Reverse();

            return result;
        }
    }
}
