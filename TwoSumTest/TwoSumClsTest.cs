using TwoSum;
using Xunit;

namespace TwoSumTest
{
    public class TwoSumClsTest
    {
        [Fact]
        public void TwoSum_test_Should_Return_Index()
        {
            int[] testData = { 2, 7, 11, 15 };

            var actual = new TwoSumCls().TwoSum(testData, 9);

            var expected = new int[] { 0, 1 };

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        [Fact]
        public void TwoSum_test_Should_Return_Index_Second()
        {
            int[] testData = { 2, 7, 11, 11 };

            var actual = new TwoSumCls().TwoSum(testData, 18);

            var expected = new int[] { 1, 2 };

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        [Fact]
        public void TwoSum_test_Should_Return_Index_Third()
        {
            int[] testData = { 2, 2, 11, 11 };

            var actual = new TwoSumCls().TwoSum(testData, 13);

            var expected = new int[] { 0, 2 };

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        [Fact]
        public void TwoSum_test_Should_Not_Return_Same_Index()
        {
            int[] testData = { 2, 7, 11, 11 };

            var actual = new TwoSumCls().TwoSum(testData, 14);

            var expected = 0;

            Assert.Equal(expected, actual.Length);
        }

        [Fact]
        public void TwoSum_test_Only_One_Element_Should_Return_Empty()
        {
            int[] testData = { 2 };

            var actual = new TwoSumCls().TwoSum(testData, 9);

            var expected = 0;

            Assert.Equal(expected, actual.Length);
        }

        [Fact]
        public void TwoSum_test_Empty_Array_Should_Return_Empty()
        {
            int[] testData = { };

            var actual = new TwoSumCls().TwoSum(testData, 9);

            var expected = 0;

            Assert.Equal(expected, actual.Length);
        }

        [Fact]
        public void TwoSum_test_No_Match_Result_Should_Return_Empty()
        {
            int[] testData = { 2, 7, 11, 15 };

            var actual = new TwoSumCls().TwoSum(testData, 100);

            var expected = 0;

            Assert.Equal(expected, actual.Length);
        }
    }
}
