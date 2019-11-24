namespace MoveZeros
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
                if (nums[i] == 0)
                    count++;
                else
                    nums[i - count] = nums[i];

            for (var j = nums.Length - 1; j >= nums.Length - count; j--) nums[j] = 0;
          
        }
    }
}