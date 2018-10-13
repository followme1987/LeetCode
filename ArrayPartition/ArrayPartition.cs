using System;

namespace ArrayPartition
{
    public class ArrayPartition
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            var count = 0;

            var numOfGroup = nums.Length / 2;

            var result = 0;

            var index = 0;

            while (count != numOfGroup)
            {
                result += Math.Min(nums[index], nums[index + 1]);
                index += 2;
                count++;
            }

            return result;
        }
    }
}