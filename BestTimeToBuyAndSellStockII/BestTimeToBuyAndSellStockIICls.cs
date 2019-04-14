namespace BestTimeToBuyAndSellStockII
{
    public class BestTimeToBuyAndSellStockIiCls
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <=1)
            {
                return 0;
            }
           
            var profit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
    }
}
