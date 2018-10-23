using System;
using System.Linq;

namespace MoveZeros
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }

            for (var j = nums.Length - 1; j >= nums.Length -count; j--)
            {
                nums[j] = 0;
            }
            //var zeroIndex = Array.IndexOf(nums, 0);
            //if (zeroIndex > -1)
            //{
            //    for (var i = zeroIndex + 1; i < nums.Length; i++)
            //    {
            //        if (nums[i] != 0)
            //        {
            //            nums[zeroIndex] = nums[i];
            //            nums[i] = 0;
            //            zeroIndex = Array.IndexOf(nums, 0);
            //        }

            //    }
            //}
           
        }
    }
}