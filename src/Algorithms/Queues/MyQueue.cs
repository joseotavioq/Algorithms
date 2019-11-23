using Algorithms.LinkedLists;

namespace Algorithms.Queues
{
    public class MyQueue<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Length { get; private set; }

        public T Peek()
        {
            if (First == null)
                return default(T);

            return First.Value;
        }

        public void Enqueue(T value)
        {
            var newNode = new Node<T>(value);

            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                Last.Next = newNode;
                Last = Last.Next;
            }

            Length++;
        }

        public T Dequeue()
        {
            if (First == null)
                return default(T);

            var value = First.Value;
            First = First.Next;
            Length--;

            if (First == null)
                Last = null;

            return value;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}
