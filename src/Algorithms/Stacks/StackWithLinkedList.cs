using Algorithms.LinkedLists;

namespace Algorithms.Stacks
{
    public class StackWithLinkedList<T>
    {
        public Node<T> Top { get; private set; }
        public Node<T> Bottom { get; private set; }
        public int Length { get; private set; }

        public T Peek()
        {
            if (Top == null)
                return default(T);

            return Top.Value;
        }

        public void Push(T value)
        {
            Node<T> temp = Top;
            Top = new Node<T>(value);
            Top.Next = temp;

            if (temp == null)
                Bottom = Top;

            Length++;
        }

        public T Pop()
        {
            if (Top == null)
                return default(T);

            var value = Top.Value;
            Top = Top.Next;
            Length--;

            if (Top == null)
                Bottom = null;

            return value;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}