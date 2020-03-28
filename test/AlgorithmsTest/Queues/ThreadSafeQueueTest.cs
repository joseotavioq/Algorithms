using Algorithms.Queues;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsTest.Queues
{
    public class ThreadSafeQueueTest
    {
        [Fact]
        public void Add_Element_On_Queue_Until_Full_It()
        {
            ThreadSafeQueue<int> threadSafeQueue = new ThreadSafeQueue<int>(5);

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
            ThreadSafeQueue<int> threadSafeQueue = new ThreadSafeQueue<int>(5);

            threadSafeQueue.Enqueue(1);

            Assert.False(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
        }

        [Fact]
        public void Empty_Queue()
        {
            ThreadSafeQueue<int> threadSafeQueue = new ThreadSafeQueue<int>(5);

            Assert.True(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
        }

        [Fact]
        public void Enqueue_Then_Dequeue_An_Element()
        {
            int elementToAdd = 1;
            ThreadSafeQueue<int> threadSafeQueue = new ThreadSafeQueue<int>(1);

            threadSafeQueue.Enqueue(elementToAdd);
            var element = threadSafeQueue.Dequeue();

            Assert.True(threadSafeQueue.IsEmpty());
            Assert.False(threadSafeQueue.IsFull());
            Assert.Equal(elementToAdd, element);
        }

        static ThreadSafeQueue<int> multiThreadQueue = new ThreadSafeQueue<int>(1);

        [Fact]
        public void MultiThread_Scenario()
        {
            int elementToAdd = 1;

            Task dequeueTask = Task.Run(() =>
            {
                var value = multiThreadQueue.Dequeue();
                Assert.Equal(elementToAdd, value);
            });

            Task enqueueTask = Task.Run(() =>
            {
                Task.Delay(500).Wait();
                multiThreadQueue.Enqueue(elementToAdd);
            });

            Task.WaitAll(dequeueTask, enqueueTask);
        }
    }
}