using System;
using System.Diagnostics;
using System.Linq;

namespace MaxmiumSubarray
{
    public class MaxmiumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var max = 0;
            var isNeg = true;
            for (var step = 0; step <= nums.Length; step++)
            {        
                for (var i = 0; i < nums.Length - step; i++)
                {
                    if (nums[i] >= 0)
                    {
                        isNeg = false;
                    }
                  
                  
                    var sum = 0;
                    sum += nums[i];

                    for (var j = i+1; j <= i + step; j++)
                    {
                        sum +=  nums[j];
                    }
                    
                    if (max < sum)
                        max = sum;
                   
                }

                if (step == 0 && isNeg)
                {
                    Array.Sort(nums);
                    return nums[nums.Length - 1];
                }
            }

            return max;
        }
    }
}
