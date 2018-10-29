using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace FirstUniqueCharacterTest
{
    public class TestDataAttribute :DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]{"leetcode", 0};
            yield return new object[]{ "loveleetcode", 2};
            yield return new object[]{ "lloodd", -1};
            yield return new object[]{ "", -1};
        }
    }
}
