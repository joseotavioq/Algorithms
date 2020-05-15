using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.LinkedLists
{
    [MemoryDiagnoser]
    public class SumLists
    {
        public IEnumerable<object[]> LinkedLists()
        {
            var first = new MyLinkedList<int>(9);
            first.Append(9);
            first.Append(9);

            var second = new MyLinkedList<int>(9);
            second.Append(9);
            second.Append(9);

            yield return new object[] { first, second };
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(LinkedLists))]
        public Node<int> FirstTry(MyLinkedList<int> first, MyLinkedList<int> second)
        {
            int firstNumber = GetNumber(first.Head, first.Length);
            int secondNumber = GetNumber(second.Head, second.Length);
            int sum = firstNumber + secondNumber;

            var result = GenerateLinkedList(sum);

            return result;
        }

        private Node<int> GenerateLinkedList(int sum)
        {
            Node<int> head = null;
            Node<int> current = null;

            while (sum > 0)
            {
                int digit = sum % 10;
                sum /= 10;

                if (head == null)
                {
                    head = new Node<int>(digit);
                    current = head;
                }
                else
                {
                    current.Next = new Node<int>(digit);
                    current = current.Next;
                }
            }

            return head;
        }

        private int GetNumber(Node<int> head, int length)
        {
            decimal number = 0;

            var current = head;
            while (current != null)
            {
                number += current.Value;
                number /= 10;

                current = current.Next;
            }

            while (length-- > 0)
                number *= 10;

            return (int)number;
        }
    }
}