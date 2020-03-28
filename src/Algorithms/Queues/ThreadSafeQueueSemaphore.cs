using System.Collections.Generic;
using System.Threading;

namespace Algorithms.Queues
{
    public class ThreadSafeQueueSemaphore<T>
    {
        private const int MAX_SIZE = 5;

        private static object _lock = new object();
        private static object _lockDequeue = new object();
        private static ManualResetEvent _manualResetEvent = new ManualResetEvent(false);
        private Queue<T> _internalQueue = new Queue<T>();
        private static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(MAX_SIZE);

        public bool IsEmpty()
        {
            return _internalQueue.Count == 0;
        }

        public bool IsFull()
        {
            return _internalQueue.Count == MAX_SIZE;
        }

        public void Enqueue(T value)
        {
            _semaphoreSlim.Wait();

            lock (_lock)
            {
                _internalQueue.Enqueue(value);
                _manualResetEvent.Set();
            }
        }

        public T Dequeue()
        {
            lock (_lockDequeue)
            {
                if (IsEmpty())
                    _manualResetEvent.WaitOne();

                _semaphoreSlim.Release();

                lock (_lock)
                    return _internalQueue.Dequeue();
            }
        }
    }
}