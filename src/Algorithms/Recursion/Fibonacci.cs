using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    [MemoryDiagnoser]
    public class Fibonacci
    {
        [Benchmark(Baseline = true)]
        [Arguments(30)]
        public int Recursive(int index)
        {
            if (index < 2)
                return index;

            return Recursive(index - 1) + Recursive(index - 2);
        }

        [Benchmark]
        [Arguments(30)]
        public int Iterative(int index)
        {
            List<int> elements = new List<int>() { 0, 1 };

            for (int i = 2; i <= index; i++)
            {
                elements.Add(elements[i - 2] + elements[i - 1]);
            }

            return elements[index];
        }

        [Benchmark]
        [Arguments(30)]
        public int IterativeWithoutMemoryAllocation(int index)
        {
            if (index < 2)
                return index;

            int a = 0, b = 1, f = 0;
            for (int i = 2; i <= index; i++)
            {
                f = a + b;
                a = b;
                b = f;
            }

            return f;
        }
    }
}