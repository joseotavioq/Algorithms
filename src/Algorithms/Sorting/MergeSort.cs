using BenchmarkDotNet.Attributes;
using System;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class MergeSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            if (listOfNumbers.Length == 1)
                return listOfNumbers;

            int middle = listOfNumbers.Length / 2;

            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
                left[i] = listOfNumbers[i];

            int[] right = new int[listOfNumbers.Length - middle];
            for (int i = middle; i < listOfNumbers.Length; i++)
                right[i - middle] = listOfNumbers[i];

            left = FirstTry(left);
            right = FirstTry(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int iLeft = 0;
            int iRight = 0;

            int iResult = 0;
            int[] result = new int[left.Length + right.Length];

            while (iLeft < left.Length || iRight < right.Length)
            {
                if (iLeft < left.Length && iRight < right.Length)
                {
                    if (left[iLeft] > right[iRight])
                    {
                        result[iResult++] = right[iRight++];
                    }
                    else
                    {
                        result[iResult++] = left[iLeft++];
                    }
                }
                else if (iLeft < left.Length)
                {
                    result[iResult++] = left[iLeft++];
                }
                else if (iRight < right.Length)
                {
                    result[iResult++] = right[iRight++];
                }
            }

            return result;
        }
    }
}