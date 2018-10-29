using AddBinary;
using Xunit;

namespace AddBinaryTest
{
    public class AddBinaryClsTest
    {
        [Fact]
        public void AddBinary_Test()
        {
            var result = new AddBinaryCls().AddBinary("11", "1");

            Assert.Equal("100", result);
        }
    }
}