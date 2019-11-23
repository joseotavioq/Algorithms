using Algorithms.Queues;
using Xunit;

namespace AlgorithmsTest.Queues
{
    public class MyQueueTest
    {
        [Fact]
        public void Queue_Is_Not_Empty()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            var isEmpty = queue.IsEmpty();

            Assert.False(isEmpty);
            Assert.Equal(1, queue.Length);
            Assert.NotNull(queue.First);
            Assert.NotNull(queue.Last);
        }

        [Fact]
        public void Queue_Is_Empty()
        {
            var queue = new MyQueue<int>();

            var isEmpty = queue.IsEmpty();

            Assert.True(isEmpty);
            Assert.Equal(0, queue.Length);
            Assert.Null(queue.First);
            Assert.Null(queue.Last);
        }

        [Fact]
        public void Enqueue_An_Element()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);

            Assert.Equal(1, queue.Length);
            Assert.Equal(10, queue.First.Value);
            Assert.Equal(10, queue.Last.Value);
        }

        [Fact]
        public void Enqueue_Two_Elements()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);

            Assert.Equal(2, queue.Length);
            Assert.Equal(10, queue.First.Value);
            Assert.Equal(20, queue.Last.Value);
        }

        [Fact]
        public void Enqueue_Three_Elements()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.Equal(3, queue.Length);
            Assert.Equal(10, queue.First.Value);
            Assert.Equal(30, queue.Last.Value);
        }

        [Fact]
        public void Dequeue_An_Element_In_A_Queue_With_One_Element()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(20);

            var item = queue.Dequeue();

            Assert.Equal(20, item);
            Assert.Equal(0, queue.Length);
            Assert.Null(queue.First);
            Assert.Null(queue.Last);
        }

        [Fact]
        public void Enqueue_An_Element_In_A_Queue_With_Two_Elements()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);

            var item = queue.Dequeue();

            Assert.Equal(10, item);
            Assert.Equal(1, queue.Length);
            Assert.Equal(20, queue.First.Value);
            Assert.Equal(20, queue.Last.Value);
        }

        [Fact]
        public void Dequeue_Two_Elements_In_A_Queue_With_Three_Elements()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var item1 = queue.Dequeue();
            var item2 = queue.Dequeue();

            Assert.Equal(10, item1);
            Assert.Equal(20, item2);
            Assert.Equal(1, queue.Length);
            Assert.Equal(30, queue.First.Value);
            Assert.Equal(30, queue.Last.Value);
        }

        [Fact]
        public void Dequeue_An_Element_In_A_Queue_With_No_Element()
        {
            var queue = new MyQueue<int>();

            var item = queue.Dequeue();

            Assert.Equal(0, item);
            Assert.Equal(0, queue.Length);
            Assert.Null(queue.First);
            Assert.Null(queue.Last);
        }

        [Fact]
        public void Peek_Element_In_A_Queue_With_Two_Elements()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);

            var item = queue.Peek();

            Assert.Equal(10, item);
            Assert.Equal(2, queue.Length);
            Assert.Equal(10, queue.First.Value);
            Assert.Equal(20, queue.Last.Value);
        }

        [Fact]
        public void Peek_Element_In_A_Queue_With_One_Element()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(20);

            var item = queue.Peek();

            Assert.Equal(20, item);
            Assert.Equal(1, queue.Length);
            Assert.Equal(20, queue.First.Value);
            Assert.Equal(20, queue.Last.Value);
        }

        [Fact]
        public void Peek_An_Element_In_A_Queue_With_No_Element()
        {
            var queue = new MyQueue<int>();

            var item = queue.Peek();

            Assert.Equal(0, item);
            Assert.Equal(0, queue.Length);
            Assert.Null(queue.First);
            Assert.Null(queue.Last);
        }
    }
}
