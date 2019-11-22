namespace Algorithms.LinkedLists
{
    public class MyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Length { get; private set; }

        public MyLinkedList(T value)
        {
            Head = new Node<T>(value);
            Tail = Head;
            Length = 1;
        }

        public void Append(T value)
        {
            var newNode = new Node<T>(value);
            Tail.Next = newNode;
            Tail = newNode;
            Length++;
        }

        public void Prepend(T value)
        {
            var newNode = new Node<T>(value);
            newNode.Next = Head;
            Head = newNode;
            Length++;
        }

        public void InsertAt(int index, T value)
        {
            if (index >= Length)
            {
                Append(value);
                return;
            }

            var newNode = new Node<T>(value);

            Node<T> previous = null;
            if (index > 0)
            {
                previous = GetAt(index - 1); //get previous element
                newNode.Next = previous.Next;
                previous.Next = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            if (newNode.Next == null)
                Tail = newNode;

            Length++;
        }

        public void RemoveAt(int index)
        {
            Node<T> previous = null;
            if (index > 0)
            {
                previous = GetAt(index - 1); //get previous element
                var elementToRemove = previous.Next;
                previous.Next = elementToRemove.Next;
            }
            else
            {
                previous = Head;
                Head = previous.Next;
            }

            if (previous.Next == null)
                Tail = previous;

            Length--;
        }

        public Node<T> GetAt(int index)
        {
            int i = 0;
            Node<T> current = Head;

            while (i != index)
            {
                current = current.Next;
                i++;
            }

            return current;
        }

        public Node<T> FindNodeBy(T value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;

                current = current.Next;
            }

            return null;
        }
    }
}