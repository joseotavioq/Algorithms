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

        public Node<T> GetAtToLast(int index)
        {
            int i = Length;
            Node<T> current = Head;

            while (i != index)
            {
                current = current.Next;
                i--;
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

        public bool IsCyclic()
        {
            return Tail.Next != null;
        }

        public void SwapNodes(int pos1, int pos2)
        {
            //Get info from Pos1
            Node<T> previousNodeAtPos1 = null;
            Node<T> nodeAtPos1 = null;
            if (pos1 - 1 < 0)
                nodeAtPos1 = Head;
            else
            {
                previousNodeAtPos1 = GetAt(pos1 - 1);
                nodeAtPos1 = previousNodeAtPos1.Next;
            }

            var nextNodeAtPos1 = nodeAtPos1.Next;

            //Get info from Pos2
            Node<T> previousNodeAtPos2 = null;
            Node<T> nodeAtPos2 = null;
            if (pos2 - 1 < 0)
                previousNodeAtPos2 = Head;
            else
            {
                previousNodeAtPos2 = GetAt(pos2 - 1);
                nodeAtPos2 = previousNodeAtPos2.Next;
            }

            var nextNodeAtPos2 = nodeAtPos2.Next;

            //Swap Pos1 and Pos2
            if (previousNodeAtPos1 != null)
                previousNodeAtPos1.Next = nodeAtPos2;
            nodeAtPos2.Next = nextNodeAtPos1;

            if (previousNodeAtPos2 != null)
                previousNodeAtPos2.Next = nodeAtPos1;
            nodeAtPos1.Next = nextNodeAtPos2;

            //Update Head
            if (previousNodeAtPos1 == null)
                Head = nodeAtPos2;
            else if (previousNodeAtPos2 == null)
                Head = nodeAtPos1;

            //Update Tail
            if (nodeAtPos2.Next == null)
                Tail = nodeAtPos2;
            else if (nodeAtPos1.Next == null)
                Tail = nodeAtPos1;
        }

        public Node<T> Copy()
        {
            Node<T> newLinkedList = new Node<T>(Head.Value);
            var currentNewLinkedList = newLinkedList;

            Node<T> current = Head.Next;
            while (current != null)
            {
                currentNewLinkedList.Next = new Node<T>(current.Value);

                current = current.Next;
                currentNewLinkedList = currentNewLinkedList.Next;
            }

            return newLinkedList;
        }

        public void Destroy()
        {
            Node<T> current = Head;

            while (current != null)
            {
                var next = current.Next;
                current.Next = null;
                current = next;
            }

            Head = null;
            Tail = null;
            Length = 0;
        }
    }
}