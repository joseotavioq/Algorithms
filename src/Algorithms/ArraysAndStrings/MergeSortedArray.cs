using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class MergeSortedArray
    {
        //Time: O(n + m)
        //Space: O(n + m)
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30 })]
        public int[] FirstTry(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length == 0)
                return secondArray;

            if (secondArray.Length == 0)
                return firstArray;

            int[] mergedSortedArray = new int[firstArray.Length + secondArray.Length];

            int k = 0, i = 0, j = 0;

            while (k < mergedSortedArray.Length)
            {
                if (i < firstArray.Length && j < secondArray.Length)
                {
                    if (firstArray[i] <= secondArray[j])
                    {
                        mergedSortedArray[k] = firstArray[i];
                        i++;
                        k++;
                    }
                    else if (firstArray[i] > secondArray[j])
                    {
                        mergedSortedArray[k] = secondArray[j];
                        j++;
                        k++;
                    }
                }
                else if (i < firstArray.Length)
                {
                    mergedSortedArray[k] = firstArray[i];
                    i++;
                    k++;
                }
                else if (j < secondArray.Length)
                {
                    mergedSortedArray[k] = secondArray[j];
                    j++;
                    k++;
                }
            }

            return mergedSortedArray;
        }

        //Time: O(n + m)
        //Space: O(n + m)
        [Benchmark]
        [Arguments(new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30 })]
        public int[] SecondTry(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length == 0)
                return secondArray;

            if (secondArray.Length == 0)
                return firstArray;

            int[] mergedSortedArray = new int[firstArray.Length + secondArray.Length];

            int k = 0, i = 0, j = 0;

            int firstItem = firstArray[i];
            int secondItem = secondArray[j];

            while (k < mergedSortedArray.Length)
            {
                if (j == secondArray.Length || firstItem < secondItem)
                {
                    mergedSortedArray[k] = firstItem;
                    i++;
                    k++;

                    if (i < firstArray.Length)
                        firstItem = firstArray[i];
                    else
                        firstItem = secondArray[secondArray.Length - 1];
                }
                else
                {
                    mergedSortedArray[k] = secondItem;
                    j++;
                    k++;

                    if (j < secondArray.Length)
                        secondItem = secondArray[j];
                }
            }

            return mergedSortedArray;
        }
    }
}