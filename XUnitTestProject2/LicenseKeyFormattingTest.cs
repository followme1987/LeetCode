using LicenseKeyFormatting;
using Xunit;

namespace XUnitTestProject2
{
    public class LicenseKeyFormattingTest
    {
        [Fact]
        public void LicenseKeyFormatting_Test()
        {
            var result = new LicenseKeyFormattingCls().LicenseKeyFormatting("2-5g-3-J", 2);

            Assert.Equal("5F3Z-2E9W", result);
        }
    }
}