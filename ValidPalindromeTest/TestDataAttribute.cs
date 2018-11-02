using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace ValidPalindromeTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {"A man, a plan, a canal: Panama", true};
            yield return new object[] {"race a car", false};
            yield return new object[] {" ", true};
            yield return new object[] {".", true};
            yield return new object[] {"a", true};
            yield return new object[] {"", true};
            yield return new object[] {"abba", true};
            yield return new object[] {"aba", true};
            yield return new object[] {"aa", true};
            yield return new object[] {"ab", false};
            yield return new object[] {"0P", false};
            yield return new object[] {"0P0", true};
            yield return new object[] {"a.", true};
        }
    }
}