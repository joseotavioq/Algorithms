using Algorithms.Queues;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsTest.Queues
{
    public class ThreadSafeQueueSemaphoreTest
    {
        [Fact]
        public void Add_Element_On_Queue_Until_Full_It()
        {
            var threadSafeQueue = new ThreadSafeQueueSemaphore<int>();

            threadSafeQueue.Enqueue(1);
            threadSafeQueue.Enqueue(2);
            threadSafeQueue.Enqueue(3);
            threadSafeQueue.Enqueue(4);
            threadSafeQueue.Enqueue(5);

            Assert.False(threadSafeQueue.IsEmpty());
            Assert.True(threadSafeQueue.IsFull());
        }

        [Fact]
        public void Add_Element_On_Queue()
        {
            var threadSafeQueue = new ThreadSafeQueueSemaphore<int>();

            threadSafeQueue.Enqueue(1);

            Assert.False(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
        }

        [Fact]
        public void Empty_Queue()
        {
            var threadSafeQueue = new ThreadSafeQueueSemaphore<int>();

            Assert.True(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
        }

        [Fact]
        public void Dequeue_Only_After_Enqueue()
        {
            int element = 1;

            var multiThreadQueue = new ThreadSafeQueueSemaphore<int>();

            Task enqueueTask = Task.Run(() =>
            {
                Task.Delay(500).Wait();
                multiThreadQueue.Enqueue(element);
            });

            var elementDequeued = multiThreadQueue.Dequeue();

            Assert.Equal(element, elementDequeued);
            Assert.True(multiThreadQueue.IsEmpty());
            Assert.False(multiThreadQueue.IsFull());
        }

        [Fact]
        public void Enqueue_Then_Dequeue_An_Element()
        {
            int elementToAdd = 1;
            var threadSafeQueue = new ThreadSafeQueueSemaphore<int>();

            threadSafeQueue.Enqueue(elementToAdd);
            var element = threadSafeQueue.Dequeue();

            Assert.True(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
            Assert.Equal(elementToAdd, element);
        }


        [Fact]
        public void MultiThread_Scenario()
        {
            var multiThreadQueue = new ThreadSafeQueueSemaphore<int>();
            int elementToAdd = 1;

            Task dequeueTask = Task.Run(() =>
            {
                Task.Delay(500).Wait();
                var value = multiThreadQueue.Dequeue();
                Assert.Equal(elementToAdd, value);
            });

            Task enqueueTask = Task.Run(() =>
            {
                multiThreadQueue.Enqueue(elementToAdd);
                multiThreadQueue.Enqueue(elementToAdd);
                multiThreadQueue.Enqueue(elementToAdd);
                multiThreadQueue.Enqueue(elementToAdd);
                multiThreadQueue.Enqueue(elementToAdd);
            });

            Task.WaitAll(enqueueTask, dequeueTask);
        }
    }
}