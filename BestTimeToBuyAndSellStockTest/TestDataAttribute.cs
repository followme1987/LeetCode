using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace BestTimeToBuyAndSellStockTest
{
    class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new[] { 7, 1, 5, 3, 6, 4 }, 5 };
            yield return new object[] { new[] { 7, 6, 4, 3, 1 }, 0 };
            yield return new object[] { new[] { 7, 6, 4, 3, 9 }, 6 };
            yield return new object[] { new[] { 7, 15, 5, 3, 6, 4 },8};
        }
    }
}
