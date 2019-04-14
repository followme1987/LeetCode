using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdMaximumNumber
{
    public class ThirdMaximumNumberCls
    {
        public int ThirdMax(int[] nums)
        {
            var set = new SortedSet<int>();

            foreach (var num in nums)
            {
                set.Add(num);
            }

            if (set.Count > 2)
            {
               return set.ElementAt(set.Count - 3);
            }
            else if(set.Count > 0)
            {
                return set.ElementAt(set.Count - 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
