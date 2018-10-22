﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace MaxmiumSubarray
{
    class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]{new []{ -2, 1, -3, 4, -1, 2, 1, -5, 4 } ,6};

            yield return new object[] { new[] { -2, -1}, -1 };

            yield return new object[] { new[] { -2 }, -2};
        }
    }
}