using Xunit;

namespace MoveZerosTest
{
    public class MoveZerosTest
    {
        [Fact]
        public void MoveZeroes_Test()
        {
            new MoveZeros.MoveZeros().MoveZeroes(new[] {0, 1, 0, 3, 12});
        }
    }
}