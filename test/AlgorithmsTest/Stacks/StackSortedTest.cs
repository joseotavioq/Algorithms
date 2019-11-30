using Algorithms.Stacks;
using Xunit;

namespace AlgorithmsTest.Stacks
{
    public class StackSortedTest
    {
        [Fact]
        public void Push_Three_Elements()
        {
            var stack = new StackSorted();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.Equal(3, stack.Length);
            Assert.Equal(10, stack.Top.Value);
            Assert.Equal(30, stack.Bottom.Value);
        }
    }
}