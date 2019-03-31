using System.Collections.Generic;

namespace TwoSum
{
    public class TwoSumCls
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1)
            {
                return new int[] { };
            }

            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var currentNum = nums[i];

                var matchNum = target - currentNum;

                if (dic.ContainsKey(matchNum))
                {
                    return new int[2] { dic[matchNum], i };
                }
                if (!dic.ContainsKey(currentNum))
                {
                    dic.Add(currentNum, i);
                }
            }

            return new int[] { };
        }
    }
}