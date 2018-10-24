using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace ClimbingStairsTest
{
    public class TestDataAttribute:DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]{2,2};
            yield return new object[]{3,3};
            yield return new object[]{5,8};

        }
    }
}
