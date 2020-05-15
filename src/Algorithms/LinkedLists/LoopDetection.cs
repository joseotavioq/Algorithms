using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.LinkedLists
{
    [MemoryDiagnoser]
    public class LoopDetection
    {
        public IEnumerable<Node<int>> LinkedLists()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            a.Next = b;
            Node<int> c = new Node<int>(3);
            b.Next = c;
            Node<int> d = new Node<int>(4);
            c.Next = d;
            Node<int> e = new Node<int>(5);
            d.Next = e;
            Node<int> f = new Node<int>(6);
            e.Next = f;
            Node<int> g = new Node<int>(7);
            f.Next = g;
            Node<int> h = new Node<int>(8);
            g.Next = h;
            Node<int> i = new Node<int>(9);
            h.Next = i;
            i.Next = b;

            yield return a;
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(LinkedLists))]
        public bool FirstTry(Node<int> head)
        {
            HashSet<Node<int>> nodes = new HashSet<Node<int>>();

            var current = head;
            while (current != null)
            {
                if (nodes.Contains(current))
                    return true;

                nodes.Add(current);
                current = current.Next;
            }

            return false;
        }

        [Benchmark]
        [ArgumentsSource(nameof(LinkedLists))]
        public bool SecondTry(Node<int> head)
        {
            var once = head;
            var twice = head;

            while (twice != null && twice.Next != null)
            {
                once = once.Next;
                twice = twice.Next.Next;

                if (once == twice)
                    return true;
            }

            return false;
        }
    }
}