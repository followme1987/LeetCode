using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace BestTimeToBuyAndSellStockIiClsTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new []{7, 1, 5, 3, 6, 4 },7};
            yield return new object[] { new []{ 1, 2, 3, 4, 5 },4};
            yield return new object[] { new []{ 7, 6, 4, 3, 1 },0};
        }
    }
}
