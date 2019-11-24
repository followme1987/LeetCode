namespace ThirdMaximumNumber
{
    public class ThirdMaximumNumberCls
    {
        public int ThirdMax(int[] nums)
        {
            //var set = new SortedSet<int>();

            //foreach (var num in nums)
            //{
            //    set.Add(num);
            //}

            //if (set.Count > 2)
            //{
            //   return set.ElementAt(set.Count - 3);
            //}
            //else if(set.Count > 0)
            //{
            //    return set.ElementAt(set.Count - 1);
            //}
            //else
            //{
            //    return 0;
            //}
            if (nums.Length == 0)
            {
                return 0;
            }
            var window = new double[] { double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity };
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != window[0] && nums[i] != window[1] && nums[i] != window[2])
                {
                    if (nums[i] > window[0])
                    {
                        window = new double[] { nums[i], window[0], window[1] };
                    }
                    else if (nums[i] > window[1])
                    {
                        window = new double[] { window[0], nums[i], window[1] };
                    }
                    else if (nums[i] > window[2])
                    {
                        window = new double[] { window[0], window[1], nums[i] };
                    }

                }

            }
            if (window[2] == double.NegativeInfinity)
            {
                return (int)window[0];
            }
            return (int)window[2];
        }
    }
}
