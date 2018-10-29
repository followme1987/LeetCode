using System;
using Xunit;

namespace FirstUniqueCharacterTest
{
    public class FirstUniqueCharacterTest
    {
        [Theory]
        [TestData]
        public void FirstUniqChar_Test(string input, int expected)
        {
            var result = new FirstUniqueCharacter.FirstUniqueCharacter().FirstUniqChar(input);

            Assert.Equal(expected,result);
        }
    }
}
