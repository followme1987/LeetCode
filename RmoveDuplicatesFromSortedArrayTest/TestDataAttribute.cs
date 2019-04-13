using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace RemoveDuplicatesFromSortedArrayTest
{
    public class TestDataAttribute:DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {new[] {1, 1, 2}, 2};
            yield return new object[]{new[]{ 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 } ,5};
        }
    }
}
