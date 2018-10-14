namespace TwoSum
{
    public class TwoSumCls
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                {
                    int[] result = {i, j};
                    return result;
                }

            return null;
        }
    }
}