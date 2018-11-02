using CountAndSay;
using Xunit;

namespace CountAndSayTest
{
    public class CountAndSayTest
    {
        [Theory]
        [TestData]
        public void CountAndSay_Test(int input, string expected)
        {
            var returned = new CountAndSayCls().CountAndSay(input);

            Assert.Equal(expected, returned);
        }
    }
}