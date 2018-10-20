using System;
using MostCommonWord;
using Xunit;

namespace XUnitTestProject1
{
    public class MostCommonWordTest
    {
        [Fact]
        public void MostCommonWord_Test()
        {
            var result= new MostCommonWordCls().MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new []{"hit"});

            Assert.Equal("ball", result);
        }
    }
}
