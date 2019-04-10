using SetMatrixZeroes;
using Xunit;

namespace SetMatrixZeroesTest
{
    public class SetMatrixZeroesClsTest
    {
        [Fact]
        public void SetZeroesTest()
        {
            int[][] matrix = { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } };

            new SetMatrixZeroesCls().SetZeroes(matrix);

            Assert.Equal(1, matrix[0][0]);
            Assert.Equal(0, matrix[0][1]);
            Assert.Equal(1, matrix[0][2]);
            Assert.Equal(0, matrix[1][0]);
            Assert.Equal(0, matrix[1][1]);
            Assert.Equal(0, matrix[1][2]);
            Assert.Equal(1, matrix[2][0]);
            Assert.Equal(0, matrix[2][1]);
            Assert.Equal(1, matrix[2][2]);
        }
    }
}
