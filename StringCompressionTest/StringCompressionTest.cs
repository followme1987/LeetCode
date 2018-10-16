using Xunit;

namespace StringCompressionTest
{
    public class StringCompressionTest
    {
        [Fact]
        public void Test_Compress_Length()
        {
            var returned = new StringCompression.StringCompression().Compress(new[]
                {'a','a','b','b','c','c','c'});

            var expected = 6;

            Assert.Equal(expected,returned);
        }

        [Fact]
        public void Test_Compress_New_Array()
        {
           // var originArr = new[] { 'a', 'a', 'a', 'b', 'b', 'b', 'c', 'c', 'c' };
          //  var originArr = new[] {'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'};
       //    var originArr = new[] { 'a','a','b', 'b', 'c', 'c', 'c' };
          var originArr = new[] { 'a', 'b', 'c' };
            //var originArr = new[]
            //{
            //    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'a', 'b', 'c'
            //};
            var returned = new StringCompression.StringCompression().Compress(originArr);

            var expected = new[]{'a','2','b','2','c','3'};

            Assert.Equal(expected.Length, originArr.Length);
        }
    }
}
