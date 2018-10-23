using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace RomanToIntegerTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {"III", 3};
            yield return new object[] {"IV", 4};
            yield return new object[] {"IX", 9};
            yield return new object[] {"LVIII", 58};
            yield return new object[] {"MCMXCIV", 1994};
            yield return new object[] {"MCDLXXVI", 1476};
        }
    }
}