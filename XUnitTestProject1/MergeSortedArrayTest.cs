using Xunit;

namespace XUnitTestProject1
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Merge_Test()
        {
            new MergeSortedArray.MergeSortedArray().Merge(new[] {2, 0}, 1, new[] {1}, 1);
        }
    }
}