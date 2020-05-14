using BenchmarkDotNet.Attributes;

namespace Algorithms.Recursion
{
    [MemoryDiagnoser]
    public class TripleStep
    {
        [Benchmark(Baseline = true)]
        [Arguments(30)]
        public int Recursive(int nSteps)
        {
            if (nSteps < 0)
                return 0;
            else if (nSteps == 0)
                return 1;

            return Recursive(nSteps - 1) + Recursive(nSteps - 2) + Recursive(nSteps - 3);
        }

        [Benchmark]
        [Arguments(30)]
        public int RecursiveWithMemoization(int nSteps)
        {
            int[] arr = new int[nSteps + 1];

            return Memoization(nSteps, arr);
        }

        private int Memoization(int nSteps, int[] arr)
        {
            if (nSteps < 0)
                return 0;
            else if (nSteps == 0)
                return 1;

            if (arr[nSteps] == 0)
                arr[nSteps] = Memoization(nSteps - 1, arr) + Memoization(nSteps - 2, arr) + Memoization(nSteps - 3, arr);

            return arr[nSteps];
        }
    }
}