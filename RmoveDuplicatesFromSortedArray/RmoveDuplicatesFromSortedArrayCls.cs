namespace RemoveDuplicatesFromSortedArray
{
    public class RmoveDuplicatesFromSortedArrayCls
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            var needToReplacePointer = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[needToReplacePointer] != nums[i])
                {
                    nums[++needToReplacePointer] = nums[i];
                }
            }

            return ++needToReplacePointer;
        }
    }
}
