using Xunit;

namespace BestTimeToBuyAndSellStockTest
{
    public class BestTimeToBuyAndSellStockTest
    {
        [Theory]
        [TestData]
        public void MaxProfit_Test(int[] input, int expected)
        {
            var btbs = new BestTimeToBuyAndSellStock.BestTimeToBuyAndSellStock();

            var result = btbs.MaxProfit(input);

            Assert.Equal(expected, result);
        }
    }
}