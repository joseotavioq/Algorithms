using BenchmarkDotNet.Attributes;

namespace Algorithms.Stacks
{
    [MemoryDiagnoser]
    public class Stacks
    {
        [Benchmark(Baseline = true)]
        public void LinkedList()
        {
            StackWithLinkedList<int> stack = new StackWithLinkedList<int>();

            for (int i = 0; i < 10000; i++)
            {
                stack.Push(i);
            }

            while(!stack.IsEmpty())
            {
                stack.Pop();
            }
        }

        [Benchmark]
        public void Array()
        {
            StackWithArray<int> stack = new StackWithArray<int>();

            for (int i = 0; i < 10000; i++)
            {
                stack.Push(i);
            }

            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
        }
    }
}
