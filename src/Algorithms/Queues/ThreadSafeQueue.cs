using System.Collections.Generic;

namespace Algorithms.Queues
{
    public class ThreadSafeQueue<T>
    {
        private static object _lock = new object();
        private Queue<T> _internalQueue = new Queue<T>();
        private int _maxSize;

        public ThreadSafeQueue(int maxSize)
        {
            _maxSize = maxSize;
        }

        public bool IsEmpty()
        {
            return _internalQueue.Count == 0;
        }

        public bool IsFull()
        {
            return _internalQueue.Count == _maxSize;
        }

        public void Enqueue(T value)
        {
            while (true)
            {
                if (!IsFull())
                {
                    lock (_lock)
                    {
                        if (!IsFull())
                        {
                            _internalQueue.Enqueue(value);
                            return;
                        }
                    }
                }

                System.Threading.Thread.SpinWait(10);
            }
        }

        public T Dequeue()
        {
            while (true)
            {
                if (!IsEmpty())
                {
                    lock (_lock)
                    {
                        if (!IsEmpty())
                        {
                            return _internalQueue.Dequeue();
                        }
                    }
                }

                System.Threading.Thread.SpinWait(10);
            }
        }
    }
}