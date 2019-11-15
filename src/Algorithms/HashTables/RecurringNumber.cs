using BenchmarkDotNet.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.HashTables
{
    [MemoryDiagnoser]
    public class RecurringNumber
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 2, 3, 1, 5, 2, 4, 1 })]
        [Arguments(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 25, 25, 14 })]
        public int FirstTry(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        return numbers[i];
                }
            }

            return -1;
        }

        [Benchmark]
        [Arguments(new int[] { 2, 3, 1, 5, 2, 4, 1 })]
        [Arguments(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 25, 25, 14 })]
        public int SecondTry(int[] numbers)
        {
            var hash = new HashSet<int>(numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (hash.Contains(numbers[i]))
                    return numbers[i];
                else
                    hash.Add(numbers[i]);
            }

            return -1;
        }
    }
}