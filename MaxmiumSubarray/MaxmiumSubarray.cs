using System;

namespace MaxmiumSubarray
{
    public class MaxmiumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var sum = 0;
            var max = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum < 0)
                {
                    sum = 0;
                    max = Math.Max(nums[i], max);
                }
                else
                {
                    max = Math.Max(sum, max);
                }
            }

            return max;
        }
    }
}