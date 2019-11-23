using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.LinkedLists
{
    [MemoryDiagnoser]
    public class Reverse
    {
        public IEnumerable<MyLinkedList<int>> LinkedLists()
        {
            var myLinkedList = new MyLinkedList<int>(0);
            for (int i = 1; i < 1000; i++)
            {
                myLinkedList.Append(i);
            }

            yield return myLinkedList;
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(LinkedLists))]
        public void FirstTry(MyLinkedList<int> myLinkedList)
        {
            myLinkedList.Reverse();
        }

        [Benchmark]
        [ArgumentsSource(nameof(LinkedLists))]
        public void SecondTry(MyLinkedList<int> myLinkedList)
        {
            myLinkedList.Reverse_AnotherWay();
        }
    }
}
