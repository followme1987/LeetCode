using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace ReverseStringTest
{
    public class TestDataAttribute : DataAttribute

    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new char[5] { 'h', 'e', 'l', 'l', 'o' } };
            //  yield return new object[] { "helo", "oleh" };
        }
    }
}
