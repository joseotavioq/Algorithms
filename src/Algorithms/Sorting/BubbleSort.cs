using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class BubbleSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (int i = 0; i < listOfNumbers.Length - 1; i++)
                {
                    if (listOfNumbers[i] > listOfNumbers[i + 1])
                    {
                        var tmp = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[i + 1];
                        listOfNumbers[i + 1] = tmp;

                        swapped = true;
                    }
                }

            } while (swapped == true);

            return listOfNumbers;
        }

        [Benchmark]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] SecondTry(int[] listOfNumbers)
        {
            for (var i = listOfNumbers.Length - 1; i > 1; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        var tmp = listOfNumbers[j];
                        listOfNumbers[j] = listOfNumbers[j + 1];
                        listOfNumbers[j + 1] = tmp;
                    }
                }
            }

            return listOfNumbers;
        }
    }
}
