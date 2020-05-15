using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.LinkedLists
{
    [MemoryDiagnoser]
    public class ReturnKthToLast
    {
        public IEnumerable<object[]> LinkedLists()
        {
            var head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 7, 4, 1, 1, 6 }).Head;

            yield return new object[] { head, 3 };
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(LinkedLists))]
        public Node<int> FirstTry(Node<int> head, int k)
        {
            int length = 0;
            var current = head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            int KthToLast = length - k;
            length = 0;
            current = head;
            while (current != null)
            {
                if (length == KthToLast)
                    return current;
                length++;
                current = current.Next;
            }

            return null;
        }

        [Benchmark]
        [ArgumentsSource(nameof(LinkedLists))]
        public Node<int> SecondTry(Node<int> head, int k)
        {
            if (head == null)
                return null;

            Node<int> result = null;

            int currentIndex = Recursive(head.Next, k, out result) + 1;
            if (currentIndex == k)
                return head;

            return result;
        }

        private int Recursive(Node<int> current, int k, out Node<int> result)
        {
            if (current == null)
            {
                result = null;
                return 0;
            }

            int currentIndex = Recursive(current.Next, k, out result) + 1;

            if (currentIndex == k)
                result = current;

            return currentIndex;
        }

        [Benchmark]
        [ArgumentsSource(nameof(LinkedLists))]
        public Node<int> ThirdTry(Node<int> head, int k)
        {
            var p1 = head;
            var p2 = head;

            //Remove k positions
            for (int i = 0; i < k; i++)
            {
                if (p1 == null)
                    return null;
                p1 = p1.Next;
            }

            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2;
        }
    }
}