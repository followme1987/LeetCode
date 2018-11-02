using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace CountAndSayTest
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {1, "1"};
            yield return new object[] {2, "11"};
            yield return new object[] {3, "21"};
            yield return new object[] {4, "1211"};
            yield return new object[] {5, "111221"};
            yield return new object[] {6, "312211"};
            yield return new object[] {7, "13112221"};
            yield return new object[] {8, "1113213211"};
        }
    }
}