using Algorithms.Stacks;
using Xunit;

namespace AlgorithmsTest.Stacks
{
    public class StackWithLinkedListTest
    {
        [Fact]
        public void Stack_Is_Not_Empty()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            var isEmpty = stack.IsEmpty();

            Assert.False(isEmpty);
            Assert.Equal(1, stack.Length);
            Assert.NotNull(stack.Top);
            Assert.NotNull(stack.Bottom);
        }

        [Fact]
        public void Stack_Is_Empty()
        {
            var stack = new StackWithLinkedList<int>();

            var isEmpty = stack.IsEmpty();

            Assert.True(isEmpty);
            Assert.Equal(0, stack.Length);
            Assert.Null(stack.Top);
            Assert.Null(stack.Bottom);
        }

        [Fact]
        public void Push_An_Element()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);

            Assert.Equal(1, stack.Length);
            Assert.Equal(10, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Push_Two_Elements()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            stack.Push(20);

            Assert.Equal(2, stack.Length);
            Assert.Equal(20, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Push_Three_Elements()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.Equal(3, stack.Length);
            Assert.Equal(30, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Pop_An_Element_In_A_Stack_With_One_Element()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(20);

            var item = stack.Pop();

            Assert.Equal(20, item);
            Assert.Equal(0, stack.Length);
            Assert.Null(stack.Top);
            Assert.Null(stack.Bottom);
        }

        [Fact]
        public void Pop_An_Element_In_A_Stack_With_Two_Elements()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            stack.Push(20);

            var item = stack.Pop();

            Assert.Equal(20, item);
            Assert.Equal(1, stack.Length);
            Assert.Equal(10, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Pop_Two_Elements_In_A_Stack_With_Three_Elements()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            var item1 = stack.Pop();
            var item2 = stack.Pop();

            Assert.Equal(30, item1);
            Assert.Equal(20, item2);
            Assert.Equal(1, stack.Length);
            Assert.Equal(10, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Pop_An_Element_In_A_Stack_With_No_Element()
        {
            var stack = new StackWithLinkedList<int>();

            var item = stack.Pop();

            Assert.Equal(0, item);
            Assert.Equal(0, stack.Length);
            Assert.Null(stack.Top);
            Assert.Null(stack.Bottom);
        }

        [Fact]
        public void Peek_Element_In_A_Stack_With_Two_Elements()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(10);
            stack.Push(20);

            var item = stack.Peek();

            Assert.Equal(20, item);
            Assert.Equal(2, stack.Length);
            Assert.Equal(20, stack.Top.Value);
            Assert.Equal(10, stack.Bottom.Value);
        }

        [Fact]
        public void Peek_Element_In_A_Stack_With_One_Element()
        {
            var stack = new StackWithLinkedList<int>();

            stack.Push(20);

            var item = stack.Peek();

            Assert.Equal(20, item);
            Assert.Equal(1, stack.Length);
            Assert.Equal(20, stack.Top.Value);
            Assert.Equal(20, stack.Bottom.Value);
        }

        [Fact]
        public void Peek_An_Element_In_A_Stack_With_No_Element()
        {
            var stack = new StackWithLinkedList<int>();

            var item = stack.Peek();

            Assert.Equal(0, item);
            Assert.Equal(0, stack.Length);
            Assert.Null(stack.Top);
            Assert.Null(stack.Bottom);
        }
    }
}