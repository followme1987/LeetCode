using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace UniqueEmailAddress.Test
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new[] { "test.email+alex@leetcode.com", "test.email@leetcode.com" }, 1 };
            yield return new object[] { new[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }, 2 };
        }
    }
}
