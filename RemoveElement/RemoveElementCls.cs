namespace RemoveElement
{
    public class RemoveElementCls
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    for (var j = nums.Length - 1; j >= 0; j--)
                    {
                        if (nums[j] == val)
                        {
                            if (i == j)
                            {
                                return j;
                            }
                            continue;
                        }

                        var temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        break;
                    }

                }
            }
            return nums.Length;
        }
    }
}
