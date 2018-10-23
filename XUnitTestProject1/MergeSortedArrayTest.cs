using Xunit;

namespace XUnitTestProject1
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Merge_Test()
        {
            new MergeSortedArray.MergeSortedArray().Merge(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3);
        }
    }
}