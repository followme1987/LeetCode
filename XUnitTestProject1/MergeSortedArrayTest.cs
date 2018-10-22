using System;
using Xunit;

namespace XUnitTestProject1
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Merge_Test()
        {
            new MergeSortedArray.MergeSortedArray().Merge(new int[]{ 2, 0 },1,new int[]{ 1 }, 1 );

           
        }
    }
}
