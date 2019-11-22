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

        public void Insert(int index, T value)
        {
            if (index >= Length)
                return;

            Node<T> current = Head;
            Node<T> previous = null;
            int i = 0;

            while (current != null)
            {
                //get previous element
                if (i == index - 1)
                {
                    previous = current;
                }
                else if (i == index) //insert the element
                {
                    var newNode = new Node<T>(value);
                    newNode.Next = current;

                    if (previous == null)
                        Head = newNode;
                    else
                        previous.Next = newNode;

                    Length++;
                    break;
                }

                current = current.Next;
                i++;
            }
        }

        public void Remove(int index)
        {
            int i = 0;
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                //get previous element
                if (i == index - 1)
                {
                    previous = current;
                }
                else if (i == index) //remove the element
                {
                    if (previous == null)
                        Head = current.Next;
                    else
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            Tail = previous;
                    }

                    Length--;
                    break;
                }

                current = current.Next;
                i++;
            }
        }
    }
}