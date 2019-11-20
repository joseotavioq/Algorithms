using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.LinkedLists
{
    /// <summary>
    /// Write code to remove duplicates from an unsorted linked list.
    /// </summary>
    [MemoryDiagnoser]
    public class RemoveDups
    {
        public Node<int> GenerateLinkedList(int[] values)
        {
            var head = new Node<int>(values[0]);

            Node<int> current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.Next = new Node<int>(values[i]);
                current = current.Next;
            }

            return head;
        }

        public IEnumerable<Node<int>> LinkedLists()
        {
            yield return GenerateLinkedList(new int[] { 1, 7, 4, 1, 1, 6 });
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(LinkedLists))]
        public Node<int> FirstTry(Node<int> head)
        {
            HashSet<int> values = new HashSet<int>();

            Node<int> previous = null;
            Node<int> current = head;
            while (current != null)
            {
                if (values.Contains(current.Value))
                {
                    previous.Next = current.Next;
                }
                else
                {
                    values.Add(current.Value);
                    previous = current;
                }

                current = current.Next;
            }

            return head;
        }

        [Benchmark]
        [ArgumentsSource(nameof(LinkedLists))]
        //Without creating a HashSet
        public Node<int> SecondTry(Node<int> head)
        {
            Node<int> currentA = head;
            while (currentA != null)
            {
                Node<int> previous = currentA;
                Node<int> currentB = currentA.Next;
                while (currentB != null)
                {
                    if (currentA.Value == currentB.Value)
                    {
                        previous.Next = currentB.Next;
                    }
                    else
                    {
                        previous = currentB;
                    }

                    currentB = currentB.Next;
                }

                currentA = currentA.Next;
            }

            return head;
        }
    }
}