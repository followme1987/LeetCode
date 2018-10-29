using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace CountPrimesTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {10, 4};
            yield return new object[] {2, 0};
            yield return new object[] {0, 0};
            yield return new object[] {1, 0};
            yield return new object[] {10000, 1229};
            yield return new object[] {12, 5};
            yield return new object[] {499979, 41537};
            yield return new object[] {999983, 41537};
        }
    }
}