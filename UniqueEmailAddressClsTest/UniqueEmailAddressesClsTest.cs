using Xunit;

namespace UniqueEmailAddress.Test
{
    public class UniqueEmailAddressesClsTest
    {
        [Theory]
        [TestData]
        public void NumUniqueEmails_Test(string[] inputs, int expected)
        {
            var actual = new UniqueEmailAddresses.UniqueEmailAddressesCls().NumUniqueEmails(inputs);

            Assert.Equal(expected, actual);
        }
    }
}
