using System;
using Xunit;

namespace MergeSortedArrayTest
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Merge_Test()
        {
            new MergeSortedArray.MergeSortedArray().Merge(new int[]{0,1,1,2,2,0,0,0 },5, new int[]{ 0,3,3},3);
        }
    }
}
