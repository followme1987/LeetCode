using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace ThirdMaximumNumberTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new int[] { 3, 2, 1 }, 1 };
            yield return new object[] { new int[] { 1, 2 }, 2 };
            yield return new object[] { new int[] { 2, 2, 3, 1 }, 1 };
            yield return new object[] { new int[] { }, 0 };
            yield return new object[] { new int[] { 1, 2, -2147483648 }, -2147483648 };
            yield return new object[] { new int[] { 1,1, 2 }, 2 };
        }
    }
}
