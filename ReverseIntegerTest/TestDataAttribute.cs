using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace ReverseIntegerTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {123, 321};
            yield return new object[] {-123, -321};
            yield return new object[] {120, 21};
            yield return new object[] {-2147483648, 0};
        }
    }
}