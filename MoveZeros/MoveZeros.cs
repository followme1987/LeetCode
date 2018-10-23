using System;
using System.Linq;

namespace MoveZeros
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            var zeroIndex = Array.IndexOf(nums, 0);
            if (zeroIndex > -1)
            {
                for (var i = zeroIndex + 1; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[zeroIndex] = nums[i];
                        nums[i] = 0;
                        zeroIndex = Array.IndexOf(nums, 0);
                    }

                }
            }
           
        }
    }
}