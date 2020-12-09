using Algorithms.Queues;
using Xunit;

namespace AlgorithmsTest.Queues
{
    public class PriorityQueueTest
    {
        [Fact]
        public void Only_One_Item()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(1);

            int peek = priorityQueue.Peek();

            Assert.Equal(1, peek);
        }

        [Fact]
        public void Two_Items()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(1);
            priorityQueue.Add(3);

            int peek = priorityQueue.Peek();

            Assert.Equal(3, peek);
        }

        [Fact]
        public void Three_Items()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(1);
            priorityQueue.Add(3);
            priorityQueue.Add(2);

            int peek = priorityQueue.Peek();

            Assert.Equal(3, peek);
        }

        [Fact]
        public void Added_In_Sorted_Way()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(1);
            priorityQueue.Add(2);
            priorityQueue.Add(3);
            priorityQueue.Add(4);
            priorityQueue.Add(5);
            priorityQueue.Add(6);
            priorityQueue.Add(7);
            priorityQueue.Add(8);
            priorityQueue.Add(9);

            int peek = priorityQueue.Peek();

            Assert.Equal(9, peek);
        }

        [Fact]
        public void Added_In_Reverse_Sorted_Way()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(9);
            priorityQueue.Add(8);
            priorityQueue.Add(7);
            priorityQueue.Add(6);
            priorityQueue.Add(5);
            priorityQueue.Add(4);
            priorityQueue.Add(3);
            priorityQueue.Add(2);
            priorityQueue.Add(1);

            int peek = priorityQueue.Peek();

            Assert.Equal(9, peek);
        }

        [Fact]
        public void Added_In_Unsorted_Way()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Add(3);
            priorityQueue.Add(8);
            priorityQueue.Add(5);
            priorityQueue.Add(7);
            priorityQueue.Add(1);
            priorityQueue.Add(6);
            priorityQueue.Add(9);
            priorityQueue.Add(4);
            priorityQueue.Add(2);

            int peek = priorityQueue.Peek();

            Assert.Equal(9, peek);
        }
    }
}