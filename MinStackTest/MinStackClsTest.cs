using MinStack;
using Xunit;

namespace MinStackTest
{
    public class MinStackClsTest
    {
        [Fact]
        public void MinStack_Test()
        {
            var stack = new MinStackCls();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Push(-3);
            stack.Pop();
            var result = stack.Top();
            var result2 = stack.GetMin();

            Assert.Equal(-3, result);
            Assert.Equal(-3, result2);
        }
    }
}