using Xunit;

namespace InsertionSortTest
{
    public class InsertionSortClsTest
    {
        [Fact]
        public void Sort_Test()
        {
            var array = new int[] { 2, 5, 1, 3, 4, 6, 2, 3, 4 };

            var sortedArray = new InsertionSort.InsertionSortCls().Sort(array);

            var expected = new int[] { 1, 2, 2, 3, 3, 4, 4, 5, 6 };

            foreach (var i in array)
            {
                Assert.Equal(expected[i], sortedArray[i]);
            }
        }
    }
}
