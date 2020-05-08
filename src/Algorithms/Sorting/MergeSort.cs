using BenchmarkDotNet.Attributes;
using System;
using TraceReloggerLib;

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

            return MergeFirst(left, right);
        }

        private int[] MergeFirst(int[] left, int[] right)
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

        [Benchmark]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] SecondTry(int[] listOfNumbers)
        {
            int[] helper = new int[listOfNumbers.Length];

            MergeSecond(listOfNumbers, helper, 0, listOfNumbers.Length - 1);

            return listOfNumbers;
        }

        private void MergeSecond(int[] listOfNumbers, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;

                //Left Half
                MergeSecond(listOfNumbers, helper, low, middle);

                //Right Half
                MergeSecond(listOfNumbers, helper, middle + 1, high);

                //Merge the Two Parts
                MergeSecond(listOfNumbers, helper, low, middle, high);
            }
        }

        private void MergeSecond(int[] listOfNumbers, int[] helper, int low, int middle, int high)
        {
            for (int i = low; i <= high; i++)
                helper[i] = listOfNumbers[i];

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while (helperLeft <= middle && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                    listOfNumbers[current++] = helper[helperLeft++];
                else
                    listOfNumbers[current++] = helper[helperRight++];
            }

            int remaining = middle - helperLeft;
            for (int i = 0; i <= remaining; i++)
                listOfNumbers[current++] = helper[helperLeft++];
        }
    }
}