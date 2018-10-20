using System;

namespace BestTimeToBuyAndSellStock
{
    public class BestTimeToBuyAndSellStock
    {


        public int MaxProfit(int[] prices)
        {
            var max = 0;

            if (prices.Length == 0)
                return 0;

            var min = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] <= min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, (prices[i] - min));
                }

            }

            return max;
        }
    }
}
