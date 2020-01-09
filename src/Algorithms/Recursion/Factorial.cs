using BenchmarkDotNet.Attributes;

namespace Algorithms.Recursion
{
    [MemoryDiagnoser]
    public class Factorial
    {
        [Benchmark]
        [Arguments(10)]
        public int Recursive(int n)
        {
            if (n <= 1)
                return 1;

            return Recursive(n - 1) * n;
        }

        [Benchmark]
        [Arguments(10)]
        public int Iterative(int n)
        {
            int result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}