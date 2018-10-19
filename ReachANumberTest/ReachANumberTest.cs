using Xunit;

namespace ReachANumberTest
{
    public class ReachANumberTest
    {
        private readonly ReachANumber.ReachANumber _ra;
        public ReachANumberTest()
        {
            _ra = new ReachANumber.ReachANumber();
        }

        [Theory]
        [TestData]
        public void ReachNumber_Test(int input, int expect)
        {
            var result = _ra.ReachNumber(input);

            Assert.Equal(expect, result);
        }
    }
}
