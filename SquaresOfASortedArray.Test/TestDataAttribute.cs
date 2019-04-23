using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace SquaresOfASortedArray.Test
{
    public class TestDataAttribute: DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]{new []{ -4, -1, 0, 3, 10 }, new []{0,1,9,16,100}};
            yield return new object[]{new []{ -7, -3, 2, 3, 11 }, new []{ 4, 9, 9, 49, 121 }};
        }
    }
}
