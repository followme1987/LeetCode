using System.Collections;
using System.Collections.Generic;

namespace RemoveElementTest
{
    public class RemoveElementTestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 3, 2, 2, 3 }, 3, 2 };
            yield return new object[] { new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
