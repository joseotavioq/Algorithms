namespace Algorithms.LinkedLists
{
    /// <summary>
    /// The parameters needed to be sorted in an ascending order.
    /// </summary>
    public class MergeTwoLinkedLists
    {
        public Node<int> FirstTry(Node<int> first, Node<int> second)
        {
            if (first == null)
                return second;

            if (second == null)
                return first;

            Node<int> head = null;
            Node<int> current = null;

            if (first.Value < second.Value)
            {
                current = first;
                first = first.Next;
            }
            else
            {
                current = second;
                second = second.Next;
            }

            head = current;

            while (first != null || second != null)
            {
                if (first == null)
                {
                    current.Next = second;
                    second = null;
                }
                else if (second == null)
                {
                    current.Next = first;
                    first = null;
                }
                else if (current.Value == first.Value)
                {
                    first = first.Next;
                    continue;
                }
                else if (current.Value == second.Value)
                {
                    second = second.Next;
                    continue;
                }
                else if (first.Value < second.Value)
                {
                    current.Next = first;
                    first = first.Next;
                }
                else if (first.Value > second.Value)
                {
                    current.Next = second;
                    second = second.Next;
                }
                else
                {
                    current.Next = first;
                    first = first.Next;
                    second = second.Next;
                }

                current = current.Next;
            }

            return head;
        }
    }
}