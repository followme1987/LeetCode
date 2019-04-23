using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace DIStringMatch.Test
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { "IDID", new[] { 0, 4, 1, 3, 2 } };
            yield return new object[] { "III", new[] { 0, 1, 2, 3 } };
            yield return new object[] { "DDI", new[] { 3, 2, 0, 1 } };
        }
    }
}
