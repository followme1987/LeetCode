using Xunit;

namespace GenerateParenthesesClsTest
{
    public class GenerateParenthesesClsTest
    {
        [Fact]
        public void GenerateParenthesis_Test()
        {
            var actual = new GenerateParentheses.GenerateParenthesesCls().GenerateParenthesis(3);

            Assert.Equal(5, actual.Count);
        }
    }
}
