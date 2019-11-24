using System;

namespace BestTimeToBuyAndSellStock
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int min = prices[0], max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] <= min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }
            return max;
        }
    }
}



