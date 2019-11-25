using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    //[MemoryDiagnoser]
    public class SumLists
    {
        //public IEnumerable<MyLinkedList<int>> LinkedLists()
        //{
        //    var first = new MyLinkedList<int>(7);
        //    first.Append(1);
        //    first.Append(6);

        //    yield return first;
        //}

        //[Benchmark(Baseline = true)]
        //[ArgumentsSource(nameof(LinkedLists))]
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

            decimal number = 0;

            Node<int> current = null;
            while (sum > 0)
            {
                number = (decimal)sum / 10;
                sum = (int)number;

                int digit = (int)((number - sum) * 10);

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

            int multiply = 10;
            for (int i = 1; i < length; i++)
            {
                multiply *= 10;
            }

            return (int)(number * multiply);
        }
    }
}