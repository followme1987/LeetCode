using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace IsomorphicStringsTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {"foo", "bar", false};
            yield return new object[] {"egg", "add", true};
            yield return new object[] {"paper", "title", true};
            yield return new object[] {"ab", "aa", false};
        }
    }
}