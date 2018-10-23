using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace ReachANumberTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {15, 5};
            yield return new object[] {10, 4};
            yield return new object[] {11, 5};
            yield return new object[] {-2, 3};
            yield return new object[] {-15, 5};
            yield return new object[] {-10, 4};
        }
    }
}