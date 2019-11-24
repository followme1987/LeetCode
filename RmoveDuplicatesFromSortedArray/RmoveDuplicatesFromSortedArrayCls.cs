namespace RemoveDuplicatesFromSortedArray
{
    public class RmoveDuplicatesFromSortedArrayCls
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return nums.Length;
            }

            var needToReplace = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[needToReplace] != nums[i])
                {
                    nums[++needToReplace] = nums[i];
                }
            }
            return ++needToReplace;

        }
    }
}






