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
        [Benchmark(Baseline = true)]
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
    }
}
