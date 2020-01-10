using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    [MemoryDiagnoser]
    public class Fibonacci
    {
        [Benchmark]
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
    }
}