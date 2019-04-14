using System;
using BestTimeToBuyAndSellStockII;
using Xunit;

namespace BestTimeToBuyAndSellStockIiClsTest
{
    public class BestTimeToBuyAndSellStockIiClsTest
    {
        [Theory]
        [TestData]
        public void MaxProfitTest(int[] inputs, int expected)
        {
            var actual = new BestTimeToBuyAndSellStockIiCls().MaxProfit(inputs);

            Assert.Equal(expected,actual);
        }
    }
}
